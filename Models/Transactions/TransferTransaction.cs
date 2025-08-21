using SealBank.Constants;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SealBank.Models.Transactions
{
    public class TransferTransaction
    (
        string name,
        DateTime dateTime,
        Guid userId,
        string userName,
        string message,
        decimal moneyAmount,
        Guid anotherUserId,
        string anotherUserName
    ) : TransactionBase(name, dateTime, userId, message, userName)
    {
        public decimal MoneyAmount { get; } = moneyAmount;
        public Guid AnotherUserId { get; } = anotherUserId; 
        public string AnotherUserName { get; } = anotherUserName;
        public override string Discriminator => "Transfer";
    }
}

