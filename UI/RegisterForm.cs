using SealBank.Constants;
using SealBank.DataSavers;
using SealBank.Managers;
using SealBank.Models.Users;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static SealBank.Logic.Validator;
using static SealBank.PasswordHelper;

namespace SealBank.UI
{
    public partial class RegisterForm : Form
    {
        private Panel mainPanel;
        private readonly Size baseSize = new Size(800, 600);
        private readonly BankManagement Bank;

        public RegisterForm(BankManagement bankManagement)
        {
            InitializeComponent();
            this.Bank = bankManagement;
            this.Size = new Size(1920, 1080);
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;


            // Создание панели
            mainPanel = new Panel();
            mainPanel.Size = baseSize;
            mainPanel.BackColor = this.BackColor;
            this.Controls.Add(mainPanel);

            MoveControlsToPanel();

            CenterPanel();

            this.Resize += RegisterForm_Resize;
        }

        private void MoveControlsToPanel()
        {
            var controls = this.Controls.Cast<Control>().ToList();

            foreach (var ctrl in controls)
            {
                if (ctrl != mainPanel)
                {
                    Point relativeLocation = this.PointToClient(ctrl.Parent.PointToScreen(ctrl.Location));
                    this.Controls.Remove(ctrl);
                    ctrl.Location = new Point(relativeLocation.X - mainPanel.Location.X, relativeLocation.Y - mainPanel.Location.Y);
                    mainPanel.Controls.Add(ctrl);
                }
            }
        }

        private void RegisterForm_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void CenterPanel()
        {
            mainPanel.Left = (this.ClientSize.Width - mainPanel.Width) / 2;
            mainPanel.Top = (this.ClientSize.Height - mainPanel.Height) / 2;
        }

        private void RegisterForm_Load(object sender, EventArgs e) 
        {
            dateTimePickerDOB.MinDate = new DateTime(1900, 1, 1);
            
            dateTimePickerDOB.MaxDate = DateTime.Today.AddYears(-14);

            dateTimePickerDOB.Value = DateTime.Today.AddYears(-18);
        }
        private void NameBox_TextChanged(object sender, EventArgs e) { }
        private void SurnameBox_TextChanged(object sender, EventArgs e) { }
        private void phoneNumberBox_TextChanged(object sender, EventArgs e) { }
        private void emailBox_TextChanged(object sender, EventArgs e) { }
        private void passwordBox_TextChanged(object sender, EventArgs e) { }
        private void repeatPassword_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }
        private void phoneLabel_Click(object sender, EventArgs e) { }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var name = NameBox.Text;
            var surname = SurnameBox.Text;
            var birthday = dateTimePickerDOB.Value;
            string? gender;

            if (maleRadioButton.Checked)
                gender = "Мужской";
            else if (femaleRadioButton.Checked)
                gender = "Женский";
            else
            {
                gender = null;
            }

            var phoneNumber = phoneNumberBox.Text;
            var email = emailBox.Text;
            var password = passwordBox.Text;
            var repeatPassword = repeatPasswordBox.Text;

            IsRegistrationSuccessful
            (
                name,
                surname,
                gender,
                phoneNumber,
                email,
                password,
                repeatPassword,
                out bool isSuccessful,
                out string? Message
            );

            if (!isSuccessful)
            {
                MessageBox.Show(Message);
                return;
            }


            var (passwordHash, salt) = HashPassword(password);
            var id = Bank.Users.Count + 1;


            var user = new User
                (name, surname, gender, birthday, email, passwordHash, salt, phoneNumber, 0, 0, [], 0);

            Bank.AddUser(user);
            Bank.SetCurrentUser(user);
            UserSaver.SaveUsers(Bank.Users);


            DialogResult = DialogResult.OK; 
            Close();
        }

        private void registerText_Click(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void genderLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
