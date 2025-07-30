using SealBank.UI;
using SealBank.DataLoaders;
using SealBank.Managers;
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

            var bankManagement = new BankManagement(bankBalance, users, history);

            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm(bankManagement));
        }
    }
}
