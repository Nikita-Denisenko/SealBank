namespace SealBank.UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            HelloText = new Label();
            EmailTextBox = new TextBox();
            NameLabel = new Label();
            EmailLabel = new Label();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            EnterLabel = new Label();
            registerButton = new Button();
            RegisterText = new Label();
            logoPictureBox = new PictureBox();
            sendButton = new Button();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // HelloText
            // 
            HelloText.AutoSize = true;
            HelloText.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HelloText.Location = new Point(160, 165);
            HelloText.Name = "HelloText";
            HelloText.Size = new Size(475, 37);
            HelloText.TabIndex = 0;
            HelloText.Text = "Добро пожаловать в SealBank!";
            HelloText.TextAlign = ContentAlignment.TopCenter;
            HelloText.Click += HelloText_Click;
            // 
            // EmailTextBox
            // 
            EmailTextBox.BackColor = Color.White;
            EmailTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EmailTextBox.Location = new Point(251, 297);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(324, 26);
            EmailTextBox.TabIndex = 1;
            EmailTextBox.TextChanged += EmailTextBox_TextChanged;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameLabel.Location = new Point(132, 153);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(0, 21);
            NameLabel.TabIndex = 2;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EmailLabel.ForeColor = Color.White;
            EmailLabel.Location = new Point(160, 297);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(72, 25);
            EmailLabel.TabIndex = 3;
            EmailLabel.Text = "E-mail:";
            EmailLabel.Click += label1_Click_1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.White;
            PasswordTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordTextBox.Location = new Point(251, 351);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(324, 26);
            PasswordTextBox.TabIndex = 4;
            PasswordTextBox.UseSystemPasswordChar = true;
            PasswordTextBox.Click += PasswordBox_TextChanged;
            PasswordTextBox.TextChanged += PasswordBox_TextChanged;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PasswordLabel.ForeColor = Color.White;
            PasswordLabel.Location = new Point(143, 351);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(89, 25);
            PasswordLabel.TabIndex = 5;
            PasswordLabel.Text = " Пароль:";
            PasswordLabel.Click += PasswordLabel_Click;
            // 
            // EnterLabel
            // 
            EnterLabel.AutoSize = true;
            EnterLabel.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EnterLabel.ForeColor = SystemColors.Control;
            EnterLabel.Location = new Point(297, 229);
            EnterLabel.Name = "EnterLabel";
            EnterLabel.Size = new Size(235, 37);
            EnterLabel.TabIndex = 7;
            EnterLabel.Text = "Вход в систему";
            EnterLabel.Click += label3_Click;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.BlueViolet;
            registerButton.Cursor = Cursors.Hand;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            registerButton.ForeColor = SystemColors.Control;
            registerButton.Location = new Point(340, 515);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(127, 26);
            registerButton.TabIndex = 8;
            registerButton.Text = "Регистрация";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButtonClick;
            // 
            // RegisterText
            // 
            RegisterText.AutoSize = true;
            RegisterText.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterText.ForeColor = SystemColors.Control;
            RegisterText.Location = new Point(179, 470);
            RegisterText.Name = "RegisterText";
            RegisterText.Size = new Size(440, 24);
            RegisterText.TabIndex = 10;
            RegisterText.Text = "Пока нет учетной записи? Зарегистрируйтесь!";
            RegisterText.Click += RegisterText_Click;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(237, -4);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(325, 166);
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPictureBox.TabIndex = 11;
            logoPictureBox.TabStop = false;
            logoPictureBox.Click += pictureBox1_Click;
            // 
            // sendButton
            // 
            sendButton.BackColor = Color.BlueViolet;
            sendButton.Cursor = Cursors.Hand;
            sendButton.FlatAppearance.BorderColor = Color.White;
            sendButton.FlatAppearance.BorderSize = 0;
            sendButton.FlatStyle = FlatStyle.Flat;
            sendButton.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sendButton.ForeColor = SystemColors.Control;
            sendButton.Location = new Point(460, 410);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(115, 26);
            sendButton.TabIndex = 9;
            sendButton.Text = "Войти";
            sendButton.UseVisualStyleBackColor = false;
            sendButton.Click += enterButtonClick;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1370, 749);
            Controls.Add(RegisterText);
            Controls.Add(sendButton);
            Controls.Add(registerButton);
            Controls.Add(EnterLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(NameLabel);
            Controls.Add(EmailTextBox);
            Controls.Add(HelloText);
            Controls.Add(logoPictureBox);
            ForeColor = SystemColors.Control;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            WindowState = FormWindowState.Maximized;
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HelloText;
        private TextBox EmailTextBox;
        private Label NameLabel;
        private Label EmailLabel;
        private TextBox PasswordTextBox;
        private Label PasswordLabel;
        private Label EnterLabel;
        private Button registerButton;
        private Label RegisterText;
        private PictureBox logoPictureBox;
        private Button sendButton;
    }
}