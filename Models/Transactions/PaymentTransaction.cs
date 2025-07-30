using SealBank.Constants;
using SealBank.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.Models.Transactions
{
    public class PaymentTransaction
    (
        TransactionType type,
        string name,
        DateTime dateTime,
        int userId,
        string userName,
        string message,
        SpendingCategory spendingCategory,
        string categoryName,
        decimal wastedMoneyAmount
    ) : TransactionBase(type, name, dateTime, userId, message, userName)

    {
        public SpendingCategory SpendingCategory { get; } = spendingCategory;
        public string CategoryName { get; } = categoryName;
        public decimal WastedMoneyAmount { get; } = wastedMoneyAmount;
    }
}
