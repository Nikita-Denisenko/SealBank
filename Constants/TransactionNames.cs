using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using static SealBank.Constants.TransactionType;

namespace SealBank.Constants
{
    public static class TransactionNames
    {
        public static readonly Dictionary<TransactionType, string> DisplayNames = new()
        {
            {Transfer, "Перевод" },
            {Payment, "Покупка" },
            {Deposit, "Пополнение счёта" },
            {Withdrawal, "Снятие наличных" },
            {Bonus, "Бонус" }
        };
    }
}
