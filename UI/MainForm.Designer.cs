namespace SealBank.UI
{
    partial class MainForm
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
            logoPanel = new Panel();
            userSurnameLabel = new Label();
            userNameLabel = new Label();
            pictureBox1 = new PictureBox();
            logoPictureBox = new PictureBox();
            menuPanel = new Panel();
            shopLinkLabel = new LinkLabel();
            otherLinkLabel = new LinkLabel();
            cardsLinkLabel = new LinkLabel();
            transfersLinkLabel = new LinkLabel();
            mainLinkLabel = new LinkLabel();
            userMenuLabel = new Label();
            historyLinkLabel = new LinkLabel();
            bonusesLinkLabel = new LinkLabel();
            depositLinkLabel = new LinkLabel();
            favouritesLinkLabel = new LinkLabel();
            creditLinkLabel = new LinkLabel();
            ProfileLinkLabel = new LinkLabel();
            HomePagePanel = new Panel();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            menuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // logoPanel
            // 
            logoPanel.BackColor = Color.MediumPurple;
            logoPanel.Controls.Add(userSurnameLabel);
            logoPanel.Controls.Add(userNameLabel);
            logoPanel.Controls.Add(pictureBox1);
            logoPanel.Controls.Add(logoPictureBox);
            logoPanel.Location = new Point(-2, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(1707, 86);
            logoPanel.TabIndex = 0;
            // 
            // userSurnameLabel
            // 
            userSurnameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userSurnameLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            userSurnameLabel.ForeColor = Color.MidnightBlue;
            userSurnameLabel.Location = new Point(642, 39);
            userSurnameLabel.Name = "userSurnameLabel";
            userSurnameLabel.Size = new Size(612, 33);
            userSurnameLabel.TabIndex = 3;
            userSurnameLabel.Text = "Иванов";
            userSurnameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // userNameLabel
            // 
            userNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userNameLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            userNameLabel.ForeColor = Color.MidnightBlue;
            userNameLabel.Location = new Point(642, 12);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(612, 33);
            userNameLabel.TabIndex = 2;
            userNameLabel.Text = "Антон";
            userNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.acetone_2025826_15739_824;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1260, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 60);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // logoPictureBox
            // 
            logoPictureBox.BackgroundImage = Properties.Resources.main_logo;
            logoPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            logoPictureBox.Location = new Point(56, -41);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(239, 169);
            logoPictureBox.TabIndex = 0;
            logoPictureBox.TabStop = false;
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.BlueViolet;
            menuPanel.Controls.Add(shopLinkLabel);
            menuPanel.Controls.Add(otherLinkLabel);
            menuPanel.Controls.Add(cardsLinkLabel);
            menuPanel.Controls.Add(transfersLinkLabel);
            menuPanel.Controls.Add(mainLinkLabel);
            menuPanel.Location = new Point(-2, 84);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(1708, 50);
            menuPanel.TabIndex = 1;
            // 
            // shopLinkLabel
            // 
            shopLinkLabel.ActiveLinkColor = Color.Gold;
            shopLinkLabel.AutoEllipsis = true;
            shopLinkLabel.AutoSize = true;
            shopLinkLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            shopLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            shopLinkLabel.LinkColor = Color.White;
            shopLinkLabel.Location = new Point(818, 10);
            shopLinkLabel.Name = "shopLinkLabel";
            shopLinkLabel.Size = new Size(178, 30);
            shopLinkLabel.TabIndex = 9;
            shopLinkLabel.TabStop = true;
            shopLinkLabel.Text = "SealBank Маркет";
            shopLinkLabel.MouseEnter += shopLinkLabel_MouseEnter;
            shopLinkLabel.MouseLeave += shopLinkLabel_MouseLeave;
            // 
            // otherLinkLabel
            // 
            otherLinkLabel.ActiveLinkColor = Color.Gold;
            otherLinkLabel.AutoEllipsis = true;
            otherLinkLabel.AutoSize = true;
            otherLinkLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            otherLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            otherLinkLabel.LinkColor = Color.White;
            otherLinkLabel.Location = new Point(1106, 10);
            otherLinkLabel.Name = "otherLinkLabel";
            otherLinkLabel.Size = new Size(88, 30);
            otherLinkLabel.TabIndex = 8;
            otherLinkLabel.TabStop = true;
            otherLinkLabel.Text = "Прочее";
            otherLinkLabel.MouseEnter += otherLinkLabel_MouseEnter;
            otherLinkLabel.MouseLeave += otherLinkLabel_MouseLeave;
            // 
            // cardsLinkLabel
            // 
            cardsLinkLabel.ActiveLinkColor = Color.Gold;
            cardsLinkLabel.AutoEllipsis = true;
            cardsLinkLabel.AutoSize = true;
            cardsLinkLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cardsLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            cardsLinkLabel.LinkColor = Color.White;
            cardsLinkLabel.Location = new Point(633, 10);
            cardsLinkLabel.Name = "cardsLinkLabel";
            cardsLinkLabel.Size = new Size(75, 30);
            cardsLinkLabel.TabIndex = 5;
            cardsLinkLabel.TabStop = true;
            cardsLinkLabel.Text = "Карты";
            cardsLinkLabel.MouseEnter += cardsLinkLabel_MouseEnter;
            cardsLinkLabel.MouseLeave += cardsLinkLabel_MouseLeave;
            // 
            // transfersLinkLabel
            // 
            transfersLinkLabel.ActiveLinkColor = Color.Gold;
            transfersLinkLabel.AutoEllipsis = true;
            transfersLinkLabel.AutoSize = true;
            transfersLinkLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            transfersLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            transfersLinkLabel.LinkColor = Color.White;
            transfersLinkLabel.Location = new Point(297, 10);
            transfersLinkLabel.Name = "transfersLinkLabel";
            transfersLinkLabel.Size = new Size(226, 30);
            transfersLinkLabel.TabIndex = 4;
            transfersLinkLabel.TabStop = true;
            transfersLinkLabel.Text = "Переводы и платежи";
            transfersLinkLabel.MouseEnter += transfersLinkLabel_MouseEnter;
            transfersLinkLabel.MouseLeave += transfersLinkLabel_MouseLeave;
            // 
            // mainLinkLabel
            // 
            mainLinkLabel.ActiveLinkColor = Color.Gold;
            mainLinkLabel.AutoEllipsis = true;
            mainLinkLabel.AutoSize = true;
            mainLinkLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            mainLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            mainLinkLabel.LinkColor = Color.White;
            mainLinkLabel.Location = new Point(96, 10);
            mainLinkLabel.Name = "mainLinkLabel";
            mainLinkLabel.Size = new Size(91, 30);
            mainLinkLabel.TabIndex = 3;
            mainLinkLabel.TabStop = true;
            mainLinkLabel.Text = "Главная";
            mainLinkLabel.MouseEnter += mainLinkLabel_MouseEnter;
            mainLinkLabel.MouseLeave += mainLinkLabel_MouseLeave;
            // 
            // userMenuLabel
            // 
            userMenuLabel.AutoSize = true;
            userMenuLabel.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            userMenuLabel.ForeColor = Color.DarkOrange;
            userMenuLabel.Location = new Point(1000, 166);
            userMenuLabel.Name = "userMenuLabel";
            userMenuLabel.Size = new Size(244, 35);
            userMenuLabel.TabIndex = 3;
            userMenuLabel.Text = "Личное меню";
            // 
            // historyLinkLabel
            // 
            historyLinkLabel.ActiveLinkColor = Color.DarkSlateBlue;
            historyLinkLabel.AutoSize = true;
            historyLinkLabel.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            historyLinkLabel.ForeColor = Color.Black;
            historyLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            historyLinkLabel.LinkColor = Color.Black;
            historyLinkLabel.Location = new Point(1000, 308);
            historyLinkLabel.Name = "historyLinkLabel";
            historyLinkLabel.Size = new Size(302, 32);
            historyLinkLabel.TabIndex = 4;
            historyLinkLabel.TabStop = true;
            historyLinkLabel.Text = "История операций";
            historyLinkLabel.LinkClicked += historyLinkLabel_LinkClicked;
            historyLinkLabel.MouseEnter += historyLinkLabel_MouseEnter;
            historyLinkLabel.MouseLeave += historyLinkLabel_MouseLeave;
            // 
            // bonusesLinkLabel
            // 
            bonusesLinkLabel.ActiveLinkColor = Color.DarkSlateBlue;
            bonusesLinkLabel.AutoSize = true;
            bonusesLinkLabel.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bonusesLinkLabel.ForeColor = Color.Black;
            bonusesLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            bonusesLinkLabel.LinkColor = Color.Black;
            bonusesLinkLabel.Location = new Point(1000, 375);
            bonusesLinkLabel.Name = "bonusesLinkLabel";
            bonusesLinkLabel.Size = new Size(242, 32);
            bonusesLinkLabel.TabIndex = 6;
            bonusesLinkLabel.TabStop = true;
            bonusesLinkLabel.Text = "Бонусы Seal-ы";
            bonusesLinkLabel.LinkClicked += bonusesLinkLabel_LinkClicked;
            bonusesLinkLabel.MouseEnter += bonusesLinkLabel_MouseEnter;
            bonusesLinkLabel.MouseLeave += bonusesLinkLabel_MouseLeave;
            // 
            // depositLinkLabel
            // 
            depositLinkLabel.ActiveLinkColor = Color.DarkSlateBlue;
            depositLinkLabel.AutoSize = true;
            depositLinkLabel.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            depositLinkLabel.ForeColor = Color.Black;
            depositLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            depositLinkLabel.LinkColor = Color.Black;
            depositLinkLabel.Location = new Point(1000, 442);
            depositLinkLabel.Name = "depositLinkLabel";
            depositLinkLabel.Size = new Size(255, 32);
            depositLinkLabel.TabIndex = 7;
            depositLinkLabel.TabStop = true;
            depositLinkLabel.Text = "Вклады и счета";
            depositLinkLabel.LinkClicked += depositLinkLabel_LinkClicked;
            depositLinkLabel.MouseEnter += depositLinkLabel_MouseEnter;
            depositLinkLabel.MouseLeave += depositLinkLabel_MouseLeave;
            // 
            // favouritesLinkLabel
            // 
            favouritesLinkLabel.ActiveLinkColor = Color.DarkSlateBlue;
            favouritesLinkLabel.AutoSize = true;
            favouritesLinkLabel.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            favouritesLinkLabel.ForeColor = Color.Black;
            favouritesLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            favouritesLinkLabel.LinkColor = Color.Black;
            favouritesLinkLabel.Location = new Point(1000, 576);
            favouritesLinkLabel.Name = "favouritesLinkLabel";
            favouritesLinkLabel.Size = new Size(184, 32);
            favouritesLinkLabel.TabIndex = 8;
            favouritesLinkLabel.TabStop = true;
            favouritesLinkLabel.Text = "Избранное";
            favouritesLinkLabel.LinkClicked += favouritesLinkLabel_LinkClicked;
            favouritesLinkLabel.MouseEnter += favouritesLinkLabel_MouseEnter;
            favouritesLinkLabel.MouseLeave += favouritesLinkLabel_MouseLeave;
            // 
            // creditLinkLabel
            // 
            creditLinkLabel.ActiveLinkColor = Color.DarkSlateBlue;
            creditLinkLabel.AutoSize = true;
            creditLinkLabel.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            creditLinkLabel.ForeColor = Color.Black;
            creditLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            creditLinkLabel.LinkColor = Color.Black;
            creditLinkLabel.Location = new Point(1000, 509);
            creditLinkLabel.Name = "creditLinkLabel";
            creditLinkLabel.Size = new Size(149, 32);
            creditLinkLabel.TabIndex = 9;
            creditLinkLabel.TabStop = true;
            creditLinkLabel.Text = "Кредиты";
            creditLinkLabel.LinkClicked += creditLinkLabel_LinkClicked;
            creditLinkLabel.MouseEnter += creditLinkLabel_MouseEnter;
            creditLinkLabel.MouseLeave += creditLinkLabel_MouseLeave;
            // 
            // ProfileLinkLabel
            // 
            ProfileLinkLabel.ActiveLinkColor = Color.DarkSlateBlue;
            ProfileLinkLabel.AutoSize = true;
            ProfileLinkLabel.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ProfileLinkLabel.ForeColor = Color.Black;
            ProfileLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            ProfileLinkLabel.LinkColor = Color.Black;
            ProfileLinkLabel.Location = new Point(1000, 241);
            ProfileLinkLabel.Name = "ProfileLinkLabel";
            ProfileLinkLabel.Size = new Size(226, 32);
            ProfileLinkLabel.TabIndex = 10;
            ProfileLinkLabel.TabStop = true;
            ProfileLinkLabel.Text = "Мой профиль";
            ProfileLinkLabel.LinkClicked += ProfileLinkLabel_LinkClicked;
            ProfileLinkLabel.MouseEnter += ProfileLinkLabel_MouseEnter;
            ProfileLinkLabel.MouseLeave += ProfileLinkLabel_MouseLeave;
            // 
            // HomePagePanel
            // 
            HomePagePanel.BackColor = Color.WhiteSmoke;
            HomePagePanel.ForeColor = SystemColors.ControlText;
            HomePagePanel.Location = new Point(0, 134);
            HomePagePanel.Name = "HomePagePanel";
            HomePagePanel.Size = new Size(955, 595);
            HomePagePanel.TabIndex = 11;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1350, 729);
            Controls.Add(HomePagePanel);
            Controls.Add(ProfileLinkLabel);
            Controls.Add(creditLinkLabel);
            Controls.Add(favouritesLinkLabel);
            Controls.Add(depositLinkLabel);
            Controls.Add(bonusesLinkLabel);
            Controls.Add(historyLinkLabel);
            Controls.Add(userMenuLabel);
            Controls.Add(menuPanel);
            Controls.Add(logoPanel);
            ForeColor = Color.Indigo;
            Name = "MainForm";
            Text = "MainForm";
            logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel logoPanel;
        private PictureBox logoPictureBox;
        private Panel menuPanel;
        private LinkLabel mainLinkLabel;
        private LinkLabel transfersLinkLabel;
        private LinkLabel cardsLinkLabel;
        private LinkLabel otherLinkLabel;
        private Label userMenuLabel;
        private LinkLabel historyLinkLabel;
        private LinkLabel bonusesLinkLabel;
        private LinkLabel depositLinkLabel;
        private LinkLabel favouritesLinkLabel;
        private PictureBox pictureBox1;
        private Label userNameLabel;
        private Label userSurnameLabel;
        private LinkLabel creditLinkLabel;
        private LinkLabel shopLinkLabel;
        private LinkLabel ProfileLinkLabel;
        private Panel HomePagePanel;
    }
}