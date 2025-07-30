using SealBank.Constants;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SealBank.Models.Transactions
{
    public class TransferTransaction
    (
        TransactionType type,
        string name,
        DateTime dateTime,
        int userId,
        string userName,
        string message,
        decimal moneyAmount,
        int anotherUserId,
        string anotherUserName
    ) : TransactionBase(type, name, dateTime, userId, message, userName)
    {
        public decimal MoneyAmount { get; } = moneyAmount;
        public int AnotherUserId { get; } = anotherUserId; 
        public string AnotherUserName { get; } = anotherUserName;
    }
}

