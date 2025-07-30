using SealBank.Constants;
using SealBank.Models.Transactions;
using SealBank.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.Logic
{
    public static class TransactionMessageService
    {
        public static string GenerateMessage(
            TransactionType type,
            string userName,
            string? anotherUserName = null,
            decimal amount = 0,
            string? categoryName = null,
            int seals = 0)
        {
            return type switch
            {
                TransactionType.Transfer when anotherUserName != null =>
                    $"{userName} перевёл {amount}₽ пользователю {anotherUserName}.",

                TransactionType.Payment when categoryName != null =>
                    $"{userName} совершил покупку на {amount}₽ в категории «{categoryName}».",

                TransactionType.Deposit =>
                    $"{userName} пополнил счёт на {amount}₽.",

                TransactionType.Withdrawal =>
                    $"{userName} снял со счёта {amount}₽.",

                TransactionType.Bonus when categoryName != null =>
                    $"{userName} получил {seals} seal за покупку в категории «{categoryName}».",

                _ => "Сообщение о транзакции недоступно."
            };
        }
    }
}
