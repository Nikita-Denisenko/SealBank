using SealBank.Interfaces;
using SealBank.Models.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SealBank.Logic
{
    public class TransactionService
    {
        public TransferTransaction Transfer(ITransferable sender, ITransferable addressee, decimal amount)
        {
            if (addressee == null)
                throw new ArgumentNullException(nameof(addressee));

            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be greater than zero.");

            if (!sender.WithdrawMoney(amount))
                throw new InvalidOperationException("Insufficient funds.");

            addressee.GiveMoney(amount);

            return new TransferTransaction(
              "Перевод",
              DateTime.Now,
              sender.Id,
              sender.Name,
              $"{sender.Name} перевёл {amount}₽ пользователю {addressee}.",
              amount,
              addressee.Id,
              addressee.Name
            );
        }
    }
}
