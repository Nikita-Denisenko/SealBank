using SealBank.Constants;
using SealBank.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.Models.Transactions
{
    public abstract class TransactionBase
    (
        TransactionType type,
        string name, 
        DateTime dateTime,
        int userId,
        string userName,
        string message
    )

    {
        public TransactionType Type { get; } = type;
        public string Name { get; } = name;
        public DateTime DateTime { get; } = dateTime;
        public int UserId { get; } = userId;
        public string UserName { get; } = userName;
        public string Message { get; } = message;
    }
}
