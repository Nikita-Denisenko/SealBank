using SealBank.Models.Transactions;
using SealBank.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.Logic
{
    public static class TransactionService
    {
        private static readonly List<TransactionBase> _transactions = new();

        public static void AddTransaction(TransactionBase transaction)
        {
            _transactions.Add(transaction);
        }

        public static IEnumerable<TransactionBase> GetUserTransactions(UserBase user)
        {
            return _transactions.Where(t => t.User == user);
        }
    }
}
