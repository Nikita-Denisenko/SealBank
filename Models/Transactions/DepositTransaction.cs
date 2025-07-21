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
        UserBase user,
        decimal moneyAmount
    ) : TransactionBase(type, name, dateTime, user)
    
    {
        public decimal MoneyAmount { get; } = moneyAmount;
    }
}
