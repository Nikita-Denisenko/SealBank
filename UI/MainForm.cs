using SealBank.Managers;
using SealBank.UI.Sections.HomeSection;


namespace SealBank.UI
{
    public partial class MainForm : Form
    {
        private readonly BankManager Bank;

        public MainForm(BankManager bankManagement)
        {
            InitializeComponent();
            this.Size = new Size(1920, 1080);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(800, 600);

            Bank = bankManagement;

            var user = bankManagement.CurrentUser;
            userNameLabel.Text = user.Name;
            userSurnameLabel.Text = user.Surname;

            // грузим профиль по умолчанию
            LoadContent(new ProfilePage(Bank));
        }

        private void LoadContent(UserControl page)
        {
            HomePagePanel.Controls.Clear();
            page.Dock = DockStyle.Fill;
            HomePagePanel.Controls.Add(page);
        }


        private void ProfileLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadContent(new ProfilePage(Bank));
        }

        private void historyLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadContent(new HistoryPage());
        }

        private void bonusesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadContent(new BonusesPage());
        }

        private void depositLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadContent(new DepositsPage());
        }

        private void creditLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadContent(new CreditsPage());
        }

        private void favouritesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadContent(new FavouritesPage());
        }

        private void mainLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            mainLinkLabel.LinkColor = Color.Gold;
        }

        private void mainLinkLabel_MouseLeave(object sender, EventArgs e)
        {
            mainLinkLabel.LinkColor = Color.White;
        }

        private void transfersLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            transfersLinkLabel.LinkColor = Color.Gold;
        }

        private void transfersLinkLabel_MouseLeave(object sender, EventArgs e)
        {
            transfersLinkLabel.LinkColor = Color.White;
        }

        private void cardsLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            cardsLinkLabel.LinkColor = Color.Gold;
        }

        private void cardsLinkLabel_MouseLeave(object sender, EventArgs e)
        {
            cardsLinkLabel.LinkColor = Color.White;
        }

        private void shopLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            shopLinkLabel.LinkColor = Color.Gold;
        }

        private void shopLinkLabel_MouseLeave(object sender, EventArgs e)
        {
            shopLinkLabel.LinkColor = Color.White;
        }

        private void otherLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            otherLinkLabel.LinkColor = Color.Gold;
        }

        private void otherLinkLabel_MouseLeave(object sender, EventArgs e)
        {
            otherLinkLabel.LinkColor = Color.White;
        }

        private void ProfileLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            ProfileLinkLabel.LinkColor = Color.DarkSlateBlue;
        }

        private void ProfileLinkLabel_MouseLeave(object sender, EventArgs e)
        {
            ProfileLinkLabel.LinkColor = Color.Black;
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

        private void favouritesLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            favouritesLinkLabel.LinkColor = Color.DarkSlateBlue;
        }

        private void favouritesLinkLabel_MouseLeave(object sender, EventArgs e)
        {
            favouritesLinkLabel.LinkColor = Color.Black;
        }
    }
}
