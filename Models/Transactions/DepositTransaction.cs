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
        string name,
        DateTime dateTime,
        Guid userId,
        string userName,
        string message,
        decimal moneyAmount
    ) : TransactionBase(name, dateTime, userId, message, userName)
    
    {
        public decimal MoneyAmount { get; } = moneyAmount;
        public override string Discriminator => "Deposit";
    }
}
