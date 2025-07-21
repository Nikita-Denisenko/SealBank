using SealBank.Constants;
using SealBank.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.Models.Transactions
{
    public class TransferTransaction
    (
        TransactionType type,
        string name,
        DateTime dateTime,
        UserBase user,
        decimal moneyAmount,
        UserBase anotherUser
    ) : TransactionBase(type, name, dateTime, user)

    {
        public decimal MoneyAmount { get; } = moneyAmount;
        public UserBase AnotherUser { get; } = anotherUser;
    }
}
