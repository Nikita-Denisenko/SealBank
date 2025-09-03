using SealBank.DataLoaders;
using SealBank.DataSavers;
using SealBank.Managers;
using SealBank.UI;
using System;
using System.Globalization;
using System.Transactions;
using System.Windows.Forms;

namespace SealBank
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;

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
