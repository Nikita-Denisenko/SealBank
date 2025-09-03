using SealBank.DataSavers;
using SealBank.Interfaces;
using SealBank.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SealBank.UI
{
    public partial class MainForm : Form
    {
        private readonly BankManagement Bank;

        public MainForm(BankManagement bankManagement)
        {
            InitializeComponent();
            this.Size = new Size(900, 630);
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            var user = bankManagement.CurrentUser;
            userNameLabel.Text = user.Name;
            userSurnameLabel.Text = user.Surname;
            surnameNameLabel.Text = $"{userSurnameLabel.Text} {userNameLabel.Text}";
            balanceLabel.Text = $"{user.Balance} ₽";
            if (user is IBonusReceivable bonusUser)
            {
                sealsLabel.Text = bonusUser.Seals.ToString();
            }
            Bank = bankManagement;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void transfersLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void mainLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            mainLinkLabel.LinkColor = Color.Magenta;

        }

        private void mainLinkLabel_MouseLeave(object sender, EventArgs e)
        {
            mainLinkLabel.LinkColor = Color.White;

        }

        private void mainLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void transfersLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            transfersLinkLabel.LinkColor = Color.Magenta;
        }

        private void transfersLinkLabel_MouseLeave(object sender, EventArgs e)
        {
            transfersLinkLabel.LinkColor = Color.White;
        }

        private void cardsLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            cardsLinkLabel.LinkColor = Color.Magenta;
        }

        private void cardsLinkLabel_MouseLeave(object sender, EventArgs e)
        {
            cardsLinkLabel.LinkColor = Color.White;
        }

        private void creditsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void otherLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            otherLinkLabel.LinkColor = Color.Magenta;
        }

        private void otherLinkLabel_MouseLeave(object sender, EventArgs e)
        {
            otherLinkLabel.LinkColor = Color.White;
        }

        private void userNamelabel_Click(object sender, EventArgs e)
        {

        }

        private void historyLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            historyLinkLabel.LinkColor = Color.DarkSlateBlue;
        }

        private void historyLinkLabel_MouseLeave(object sender, EventArgs e)
        {
            historyLinkLabel.LinkColor = Color.Black;
        }

        private void bonusesLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            bonusesLinkLabel.LinkColor = Color.DarkSlateBlue;
        }

        private void bonusesLinkLabel_MouseLeave(object sender, EventArgs e)
        {
            bonusesLinkLabel.LinkColor = Color.Black;
        }

        private void favouritesLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            favouritesLinkLabel.LinkColor = Color.DarkSlateBlue;
        }

        private void favouritesLinkLabel_MouseLeave(object sender, EventArgs e)
        {
            favouritesLinkLabel.LinkColor = Color.Black;
        }

        private void depositLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            depositLinkLabel.LinkColor = Color.DarkSlateBlue;
        }

        private void depositLinkLabel_MouseLeave(object sender, EventArgs e)
        {
            depositLinkLabel.LinkColor = Color.Black;
        }

        private void creditLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            creditLinkLabel.LinkColor = Color.DarkSlateBlue;
        }

        private void creditLinkLabel_MouseLeave(object sender, EventArgs e)
        {
            creditLinkLabel.LinkColor = Color.Black;
        }

        private void shopLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            shopLinkLabel.LinkColor = Color.Magenta;
        }

        private void shopLinkLabel_MouseLeave(object sender, EventArgs e)
        {
            shopLinkLabel.LinkColor = Color.White;
        }

        private void userSurnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProfileLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            ProfileLinkLabel.LinkColor = Color.DarkSlateBlue;
        }

        private void ProfileLinkLabel_MouseLeave(object sender, EventArgs e)
        {
            ProfileLinkLabel.LinkColor = Color.Black;
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}