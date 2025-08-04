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
            genderLabel = new Label();
            maleRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            birthDayLabel = new Label();
            dateTimePickerDOB = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // registerText
            // 
            registerText.AutoSize = true;
            registerText.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerText.ForeColor = SystemColors.Control;
            registerText.Location = new Point(299, 121);
            registerText.Name = "registerText";
            registerText.Size = new Size(240, 43);
            registerText.TabIndex = 0;
            registerText.Text = "Регистрация";
            registerText.Click += registerText_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(346, -24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(299, 186);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(240, 23);
            NameBox.TabIndex = 2;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // SurnameBox
            // 
            SurnameBox.Location = new Point(299, 226);
            SurnameBox.Name = "SurnameBox";
            SurnameBox.Size = new Size(240, 23);
            SurnameBox.TabIndex = 3;
            SurnameBox.TextChanged += SurnameBox_TextChanged;
            // 
            // phoneNumberBox
            // 
            phoneNumberBox.Location = new Point(299, 346);
            phoneNumberBox.Name = "phoneNumberBox";
            phoneNumberBox.Size = new Size(240, 23);
            phoneNumberBox.TabIndex = 4;
            phoneNumberBox.TextChanged += phoneNumberBox_TextChanged;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(299, 386);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(240, 23);
            emailBox.TabIndex = 5;
            emailBox.TextChanged += emailBox_TextChanged;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(299, 426);
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
            NameLabel.Location = new Point(235, 188);
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
            SurnameLabel.Location = new Point(191, 226);
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
            phoneLabel.Location = new Point(135, 346);
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
            passwordLabel.Location = new Point(209, 426);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 21);
            passwordLabel.TabIndex = 11;
            passwordLabel.Text = "Пароль";
            passwordLabel.Click += passwordLabel_Click;
            // 
            // emailText
            // 
            emailText.AutoSize = true;
            emailText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            emailText.ForeColor = Color.White;
            emailText.Location = new Point(215, 386);
            emailText.Name = "emailText";
            emailText.Size = new Size(59, 21);
            emailText.TabIndex = 12;
            emailText.Text = "E-mail";
            // 
            // repeatPasswordBox
            // 
            repeatPasswordBox.Location = new Point(299, 466);
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
            repeatPasswordLabel.Location = new Point(123, 466);
            repeatPasswordLabel.Name = "repeatPasswordLabel";
            repeatPasswordLabel.Size = new Size(156, 21);
            repeatPasswordLabel.TabIndex = 14;
            repeatPasswordLabel.Text = "Повторите пароль";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox1.Location = new Point(191, 518);
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
            registerButton.Location = new Point(364, 560);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(175, 26);
            registerButton.TabIndex = 16;
            registerButton.Text = "Зарегистрироваться";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            genderLabel.ForeColor = Color.White;
            genderLabel.Location = new Point(197, 306);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(77, 21);
            genderLabel.TabIndex = 18;
            genderLabel.Text = "Ваш пол";
            genderLabel.Click += genderLabel_Click;
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maleRadioButton.Location = new Point(299, 306);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(95, 25);
            maleRadioButton.TabIndex = 19;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Мужской";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            femaleRadioButton.Location = new Point(419, 306);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(92, 25);
            femaleRadioButton.TabIndex = 20;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Женский";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // birthDayLabel
            // 
            birthDayLabel.AutoSize = true;
            birthDayLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            birthDayLabel.ForeColor = Color.White;
            birthDayLabel.Location = new Point(141, 266);
            birthDayLabel.Name = "birthDayLabel";
            birthDayLabel.Size = new Size(133, 21);
            birthDayLabel.TabIndex = 21;
            birthDayLabel.Text = "Дата рождения";
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Location = new Point(299, 266);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(240, 23);
            dateTimePickerDOB.TabIndex = 22;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1292, 627);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(birthDayLabel);
            Controls.Add(femaleRadioButton);
            Controls.Add(maleRadioButton);
            Controls.Add(genderLabel);
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
        private Label genderLabel;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
        private Label birthDayLabel;
        private DateTimePicker dateTimePickerDOB;
    }
}