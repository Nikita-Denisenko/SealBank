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
        string name, 
        DateTime dateTime,
        Guid userId,
        string userName,
        string message
    )

    {
        public Guid TransactionTypeId { get; } = Guid.NewGuid();
        public string Name { get; } = name;
        public DateTime DateTime { get; } = dateTime;
        public Guid UserId { get; } = userId;
        public string UserName { get; } = userName;
        public string Message { get; } = message;
        public abstract string Discriminator { get; }
    }
}
