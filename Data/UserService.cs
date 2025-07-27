using SealBank.Models.Transactions;
using SealBank.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SealBank.Data
{
    public class UserService
    (
        List<UserBase> users,
        List<TransactionBase> transactionsHistory
    )
    {
        public List<UserBase> Users { get; } = users;
        public List<TransactionBase> TransactionHistory { get; } = transactionsHistory;
    }
}
