using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SealBank.UI
{
    public partial class RegisterForm : Form
    {
        private Panel mainPanel;
        private readonly Size baseSize = new Size(800, 600);

        public RegisterForm()
        {
            InitializeComponent();
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

        private void RegisterForm_Load(object sender, EventArgs e) { }
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
    }
}
