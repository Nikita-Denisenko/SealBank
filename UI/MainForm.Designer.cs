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
            historyPanel = new Panel();
            pictureBox3 = new PictureBox();
            sealsLabel = new Label();
            sealsTextLabel = new Label();
            balanceLabel = new Label();
            balanceTextLabel = new Label();
            surnameNameLabel = new Label();
            pictureBox2 = new PictureBox();
            userMenuLabel = new Label();
            historyLinkLabel = new LinkLabel();
            bonusesLinkLabel = new LinkLabel();
            depositLinkLabel = new LinkLabel();
            favouritesLinkLabel = new LinkLabel();
            creditLinkLabel = new LinkLabel();
            ProfileLinkLabel = new LinkLabel();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            menuPanel.SuspendLayout();
            historyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            userSurnameLabel.Click += userSurnameLabel_Click;
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
            shopLinkLabel.ActiveLinkColor = Color.Magenta;
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
            otherLinkLabel.ActiveLinkColor = Color.Magenta;
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
            cardsLinkLabel.ActiveLinkColor = Color.Magenta;
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
            transfersLinkLabel.ActiveLinkColor = Color.Magenta;
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
            mainLinkLabel.ActiveLinkColor = Color.Magenta;
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
            // historyPanel
            // 
            historyPanel.BackColor = SystemColors.Control;
            historyPanel.Controls.Add(label1);
            historyPanel.Controls.Add(pictureBox4);
            historyPanel.Controls.Add(pictureBox3);
            historyPanel.Controls.Add(sealsLabel);
            historyPanel.Controls.Add(sealsTextLabel);
            historyPanel.Controls.Add(balanceLabel);
            historyPanel.Controls.Add(balanceTextLabel);
            historyPanel.Controls.Add(surnameNameLabel);
            historyPanel.Controls.Add(pictureBox2);
            historyPanel.Location = new Point(0, 134);
            historyPanel.Name = "historyPanel";
            historyPanel.Size = new Size(955, 595);
            historyPanel.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.seal_bonus;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(462, 244);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 45);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // sealsLabel
            // 
            sealsLabel.AutoSize = true;
            sealsLabel.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            sealsLabel.ForeColor = Color.BlueViolet;
            sealsLabel.Location = new Point(502, 252);
            sealsLabel.Name = "sealsLabel";
            sealsLabel.Size = new Size(47, 29);
            sealsLabel.TabIndex = 7;
            sealsLabel.Text = "25";
            sealsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sealsTextLabel
            // 
            sealsTextLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sealsTextLabel.ForeColor = Color.Black;
            sealsTextLabel.Location = new Point(387, 255);
            sealsTextLabel.Name = "sealsTextLabel";
            sealsTextLabel.Size = new Size(78, 32);
            sealsTextLabel.TabIndex = 6;
            sealsTextLabel.Text = "Seal-ы: ";
            sealsTextLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            balanceLabel.ForeColor = Color.ForestGreen;
            balanceLabel.Location = new Point(462, 212);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(116, 25);
            balanceLabel.TabIndex = 5;
            balanceLabel.Text = "18 000 ₽";
            balanceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // balanceTextLabel
            // 
            balanceTextLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            balanceTextLabel.ForeColor = Color.Black;
            balanceTextLabel.Location = new Point(387, 209);
            balanceTextLabel.Name = "balanceTextLabel";
            balanceTextLabel.Size = new Size(78, 32);
            balanceTextLabel.TabIndex = 4;
            balanceTextLabel.Text = "Баланс: ";
            balanceTextLabel.TextAlign = ContentAlignment.MiddleLeft;
            balanceTextLabel.Click += label1_Click_2;
            // 
            // surnameNameLabel
            // 
            surnameNameLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            surnameNameLabel.ForeColor = Color.Indigo;
            surnameNameLabel.Location = new Point(0, 150);
            surnameNameLabel.Name = "surnameNameLabel";
            surnameNameLabel.Size = new Size(955, 40);
            surnameNameLabel.TabIndex = 3;
            surnameNameLabel.Text = "Забеев Тимур";
            surnameNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.acetone_2025826_15739_824;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(410, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(135, 90);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // userMenuLabel
            // 
            userMenuLabel.AutoSize = true;
            userMenuLabel.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
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
            ProfileLinkLabel.MouseEnter += ProfileLinkLabel_MouseEnter;
            ProfileLinkLabel.MouseLeave += ProfileLinkLabel_MouseLeave;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.card;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(77, 308);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(379, 250);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.BlueViolet;
            label1.Location = new Point(502, 334);
            label1.Name = "label1";
            label1.Size = new Size(295, 197);
            label1.TabIndex = 10;
            label1.Text = "Будущее в надёжных ластах!";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1350, 729);
            Controls.Add(ProfileLinkLabel);
            Controls.Add(creditLinkLabel);
            Controls.Add(favouritesLinkLabel);
            Controls.Add(depositLinkLabel);
            Controls.Add(bonusesLinkLabel);
            Controls.Add(historyLinkLabel);
            Controls.Add(userMenuLabel);
            Controls.Add(historyPanel);
            Controls.Add(menuPanel);
            Controls.Add(logoPanel);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            historyPanel.ResumeLayout(false);
            historyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private Panel historyPanel;
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
        private PictureBox pictureBox2;
        private Label surnameNameLabel;
        private Label balanceTextLabel;
        private Label balanceLabel;
        private Label sealsTextLabel;
        private Label sealsLabel;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
    }
}