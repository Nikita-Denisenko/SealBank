using SealBank.Interfaces;
using SealBank.Managers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SealBank.UI.Sections.HomeSection
{
    public class ProfilePage : UserControl
    {
        private readonly BankManager _bankManager;

        // --- поля контролов ---
        private PictureBox pictureBox2;
        private Label surnameNameLabel;
        private Label balanceTextLabel;
        private Label balanceLabel;
        private Label sealsTextLabel;
        private PictureBox pictureBox3;
        private Label sealsLabel;
        private PictureBox pictureBox4;
        private Label label1;

        public ProfilePage(BankManager bankManagement)
        {
            _bankManager = bankManagement;
            InitializeComponent(); // создаём контролы
            LoadUserData();        // подгружаем данные
        }

        /// <summary>
        /// Загружает данные пользователя из BankManager в контролы.
        /// </summary>
        private void LoadUserData()
        {
            var user = _bankManager.CurrentUser;

            surnameNameLabel.Text = $"{user.Name} {user.Surname}";
            balanceLabel.Text = $"{user.Balance} ₽";

            if (user is IBonusReceivable bonusUser)
            {
                sealsLabel.Text = bonusUser.Seals.ToString();
            }
        }

        /// <summary>
        /// Разметка и создание контролов (дизайн).
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox2 = new PictureBox();
            surnameNameLabel = new Label();
            balanceTextLabel = new Label();
            balanceLabel = new Label();
            sealsTextLabel = new Label();
            pictureBox3 = new PictureBox();
            sealsLabel = new Label();
            pictureBox4 = new PictureBox();
            label1 = new Label();

            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2 (логотип/картинка сверху)
            // 
            pictureBox2.BackgroundImage = Properties.Resources.acetone_2025826_15739_824;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(410, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(135, 90);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // surnameNameLabel (ФИО)
            // 
            surnameNameLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            surnameNameLabel.ForeColor = Color.Indigo;
            surnameNameLabel.Location = new Point(0, 150);
            surnameNameLabel.Name = "surnameNameLabel";
            surnameNameLabel.Size = new Size(955, 40);
            surnameNameLabel.TabIndex = 4;
            surnameNameLabel.Text = "ФИО";
            surnameNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // balanceTextLabel (подпись "Баланс")
            // 
            balanceTextLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            balanceTextLabel.ForeColor = Color.Black;
            balanceTextLabel.Location = new Point(387, 209);
            balanceTextLabel.Name = "balanceTextLabel";
            balanceTextLabel.Size = new Size(78, 32);
            balanceTextLabel.TabIndex = 5;
            balanceTextLabel.Text = "Баланс:";
            balanceTextLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // balanceLabel (сумма баланса)
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            balanceLabel.ForeColor = Color.ForestGreen;
            balanceLabel.Location = new Point(462, 212);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(116, 25);
            balanceLabel.TabIndex = 6;
            balanceLabel.Text = "0 ₽";
            balanceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sealsTextLabel (подпись "Seal-ы")
            // 
            sealsTextLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sealsTextLabel.ForeColor = Color.Black;
            sealsTextLabel.Location = new Point(387, 255);
            sealsTextLabel.Name = "sealsTextLabel";
            sealsTextLabel.Size = new Size(78, 32);
            sealsTextLabel.TabIndex = 7;
            sealsTextLabel.Text = "Seal-ы:";
            sealsTextLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox3 (иконка для seal-ов)
            // 
            pictureBox3.BackgroundImage = Properties.Resources.seal_bonus;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(462, 244);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 45);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // sealsLabel (число seal-ов)
            // 
            sealsLabel.AutoSize = true;
            sealsLabel.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            sealsLabel.ForeColor = Color.BlueViolet;
            sealsLabel.Location = new Point(502, 252);
            sealsLabel.Name = "sealsLabel";
            sealsLabel.Size = new Size(47, 29);
            sealsLabel.TabIndex = 10;
            sealsLabel.Text = "0";
            sealsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox4 (карточка банка)
            // 
            pictureBox4.BackgroundImage = Properties.Resources.card;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(77, 308);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(379, 250);
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // label1 (слоган)
            // 
            label1.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.BlueViolet;
            label1.Location = new Point(502, 334);
            label1.Name = "label1";
            label1.Size = new Size(295, 197);
            label1.TabIndex = 12;
            label1.Text = "Будущее в надёжных ластах!";
            // 
            // ProfilePage (сам UserControl)
            // 
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(sealsLabel);
            Controls.Add(pictureBox3);
            Controls.Add(sealsTextLabel);
            Controls.Add(balanceLabel);
            Controls.Add(balanceTextLabel);
            Controls.Add(surnameNameLabel);
            Controls.Add(pictureBox2);
            Name = "ProfilePage";
            Size = new Size(955, 595);

            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
