using SealBank.Constants;
using SealBank.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.Models.Transactions
{
    public class DepositTransaction
    (
        TransactionType type,
        string name,
        DateTime dateTime,
        int userId,
        string userName,
        string message,
        decimal moneyAmount
    ) : TransactionBase(type, name, dateTime, userId, message, userName)
    
    {
        public decimal MoneyAmount { get; } = moneyAmount;
    }
}
