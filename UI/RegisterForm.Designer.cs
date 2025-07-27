namespace SealBank.UI
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            registerText = new Label();
            pictureBox1 = new PictureBox();
            NameBox = new TextBox();
            SurnameBox = new TextBox();
            phoneNumberBox = new TextBox();
            emailBox = new TextBox();
            passwordBox = new TextBox();
            NameLabel = new Label();
            SurnameLabel = new Label();
            phoneLabel = new Label();
            emailLabel = new Label();
            passwordLabel = new Label();
            emailText = new Label();
            repeatPasswordBox = new TextBox();
            repeatPasswordLabel = new Label();
            checkBox1 = new CheckBox();
            registerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // registerText
            // 
            registerText.AutoSize = true;
            registerText.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerText.ForeColor = SystemColors.Control;
            registerText.Location = new Point(299, 158);
            registerText.Name = "registerText";
            registerText.Size = new Size(240, 43);
            registerText.TabIndex = 0;
            registerText.Text = "Регистрация";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(332, -23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(299, 230);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(240, 23);
            NameBox.TabIndex = 2;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // SurnameBox
            // 
            SurnameBox.Location = new Point(299, 270);
            SurnameBox.Name = "SurnameBox";
            SurnameBox.Size = new Size(240, 23);
            SurnameBox.TabIndex = 3;
            SurnameBox.TextChanged += SurnameBox_TextChanged;
            // 
            // phoneNumberBox
            // 
            phoneNumberBox.Location = new Point(299, 310);
            phoneNumberBox.Name = "phoneNumberBox";
            phoneNumberBox.Size = new Size(240, 23);
            phoneNumberBox.TabIndex = 4;
            phoneNumberBox.TextChanged += phoneNumberBox_TextChanged;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(299, 350);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(240, 23);
            emailBox.TabIndex = 5;
            emailBox.TextChanged += emailBox_TextChanged;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(299, 390);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(240, 23);
            passwordBox.TabIndex = 6;
            passwordBox.UseSystemPasswordChar = true;
            passwordBox.TextChanged += passwordBox_TextChanged;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameLabel.ForeColor = Color.White;
            NameLabel.Location = new Point(229, 230);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(44, 21);
            NameLabel.TabIndex = 7;
            NameLabel.Text = "Имя";
            NameLabel.Click += label1_Click;
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SurnameLabel.ForeColor = Color.White;
            SurnameLabel.Location = new Point(190, 270);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(83, 21);
            SurnameLabel.TabIndex = 8;
            SurnameLabel.Text = "Фамилия";
            SurnameLabel.Click += label2_Click;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            phoneLabel.ForeColor = Color.White;
            phoneLabel.Location = new Point(129, 310);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(144, 21);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "Номер телефона";
            phoneLabel.Click += phoneLabel_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            emailLabel.ForeColor = Color.White;
            emailLabel.Location = new Point(203, 386);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(0, 21);
            emailLabel.TabIndex = 10;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(203, 390);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 21);
            passwordLabel.TabIndex = 11;
            passwordLabel.Text = "Пароль";
            // 
            // emailText
            // 
            emailText.AutoSize = true;
            emailText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            emailText.ForeColor = Color.White;
            emailText.Location = new Point(214, 350);
            emailText.Name = "emailText";
            emailText.Size = new Size(59, 21);
            emailText.TabIndex = 12;
            emailText.Text = "E-mail";
            // 
            // repeatPasswordBox
            // 
            repeatPasswordBox.Location = new Point(299, 430);
            repeatPasswordBox.Name = "repeatPasswordBox";
            repeatPasswordBox.Size = new Size(240, 23);
            repeatPasswordBox.TabIndex = 13;
            repeatPasswordBox.UseSystemPasswordChar = true;
            repeatPasswordBox.TextChanged += repeatPassword_TextChanged;
            // 
            // repeatPasswordLabel
            // 
            repeatPasswordLabel.AutoSize = true;
            repeatPasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            repeatPasswordLabel.ForeColor = Color.White;
            repeatPasswordLabel.Location = new Point(117, 430);
            repeatPasswordLabel.Name = "repeatPasswordLabel";
            repeatPasswordLabel.Size = new Size(156, 21);
            repeatPasswordLabel.TabIndex = 14;
            repeatPasswordLabel.Text = "Повторите пароль";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox1.Location = new Point(191, 483);
            checkBox1.Name = "checkBox1";
            checkBox1.RightToLeft = RightToLeft.Yes;
            checkBox1.Size = new Size(348, 25);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Я обещаю быть Seal-ьным пользователем\r\n";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.BlueViolet;
            registerButton.Cursor = Cursors.Hand;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            registerButton.ForeColor = SystemColors.Control;
            registerButton.Location = new Point(364, 523);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(175, 26);
            registerButton.TabIndex = 16;
            registerButton.Text = "Зарегистрироваться";
            registerButton.UseVisualStyleBackColor = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(800, 627);
            Controls.Add(registerButton);
            Controls.Add(checkBox1);
            Controls.Add(repeatPasswordLabel);
            Controls.Add(repeatPasswordBox);
            Controls.Add(emailText);
            Controls.Add(passwordLabel);
            Controls.Add(emailLabel);
            Controls.Add(phoneLabel);
            Controls.Add(SurnameLabel);
            Controls.Add(NameLabel);
            Controls.Add(passwordBox);
            Controls.Add(emailBox);
            Controls.Add(phoneNumberBox);
            Controls.Add(SurnameBox);
            Controls.Add(NameBox);
            Controls.Add(pictureBox1);
            Controls.Add(registerText);
            ForeColor = SystemColors.Control;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label registerText;
        private PictureBox pictureBox1;
        private TextBox NameBox;
        private TextBox SurnameBox;
        private TextBox phoneNumberBox;
        private TextBox emailBox;
        private TextBox passwordBox;
        private Label NameLabel;
        private Label SurnameLabel;
        private Label phoneLabel;
        private Label emailLabel;
        private Label passwordLabel;
        private Label emailText;
        private TextBox repeatPasswordBox;
        private Label repeatPasswordLabel;
        private CheckBox checkBox1;
        private Button registerButton;
    }
}