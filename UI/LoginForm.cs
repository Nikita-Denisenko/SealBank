using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using static SealBank.Logic.Validator;

using SealBank.Managers;

namespace SealBank.UI
{
    public partial class LoginForm : Form
    {
        private Panel mainPanel;
        private readonly Size baseSize = new Size(800, 600);
        private readonly BankManagement BankManagement;

        public LoginForm(BankManagement bankManagement) 
        {
            InitializeComponent();
            this.BankManagement = bankManagement;
            this.Size = new Size(1920, 1080);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(800, 600);

            mainPanel = new Panel();
            mainPanel.Size = baseSize;
            mainPanel.BackColor = this.BackColor;
            this.Controls.Add(mainPanel);

            MoveControlsToPanel();

            CenterPanel();

            this.Resize += LoginForm_Resize;
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

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void CenterPanel()
        {
            mainPanel.Left = (this.ClientSize.Width - mainPanel.Width) / 2;
            mainPanel.Top = (this.ClientSize.Height - mainPanel.Height) / 2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HelloText_Click(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            RoundButton(sendButton);
            RoundButton(registerButton);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RegisterText_Click(object sender, EventArgs e)
        {

        }

        private void RoundButton(Button btn)
        {
            int radius = 2;
            Rectangle bounds = new Rectangle(0, 0, btn.Width, btn.Height);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void enterButtonClick(object sender, EventArgs e)
        {
            var email = EmailTextBox.Text;
            
        }

        private void registerButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            var registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
