using SealBank.Models.Transactions;
using SealBank.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.Managers
{
    public class BankManagement
    (
        decimal bankBalance,
        List<UserBase> users,
        List<TransactionBase> transactionHistory
    )
    {
        public decimal BankBalance { get; private set; } = bankBalance;
        public List<UserBase> Users { get; } = users;
        public List<TransactionBase> TransactionHistory { get; } = transactionHistory;

        public void AddUser(User user) => Users.Add(user);
        public void AddTransaction(TransactionBase transaction) => TransactionHistory.Add(transaction);
        public void AddToBankBalance(decimal amount) => BankBalance += amount;
        public bool TryWithdrawFromBank(decimal amount)
        {
            if (BankBalance < amount) return false;
            BankBalance -= amount;
            return true;
        }
    }
}
