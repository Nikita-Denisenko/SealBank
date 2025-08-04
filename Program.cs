using SealBank.UI;
using SealBank.DataLoaders;
using SealBank.Managers;
using SealBank.DataSavers;
using System;
using System.Windows.Forms;
using System.Transactions;


namespace SealBank
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var bankBalance = BankSettingsLoader.LoadBalance("Data/bankBalance.json");
            var users = UserLoader.LoadUsers("Data/users.json");
            var history = HistoryLoader.LoadHistory("Data/history.json");

            var bank = new BankManagement(bankBalance, users, history);

            ApplicationConfiguration.Initialize();

            using (var loginForm = new LoginForm(bank))
            {
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }

            var mainForm = new MainForm(bank);
            Application.Run(mainForm);
        }
    }
}
