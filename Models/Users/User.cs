using SealBank.Constants;
using SealBank.Interfaces;
using SealBank.Models.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static SealBank.Constants.TransactionNames;
using static SealBank.Logic.TransactionMessageService;

namespace SealBank.Models.Users
{
    public class User
    (
        int id,
        string name,
        string surname,
        string gender,
        DateTime birthDay,
        string email,
        string password,
        string phoneNumber,
        UserType userType,
        decimal balance,
        List<TransactionBase> history
    )   : UserBase
        (
            id, name, surname, gender, birthDay, 
            email, password, phoneNumber, userType,
            balance, history
        ),
        ITransferable,
        IBonusReceivable
    {
        public List<SpendingCategory> SpendingCategories { get; private set; } = [];
        public int BasicBonusPercent { get; } = 1;

        public int Seals { get; private set; } = 0;

        public List<SpendingCategory> ChooseCategories()
        {
            return new List<SpendingCategory>();
        }

        public void AddSealBonus(int amount)
        {
            Seals += amount;
        }

        public TransferTransaction Transfer(UserBase addressee, decimal amount)
        {
            if (addressee == null)
                throw new ArgumentNullException(nameof(addressee));

            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be greater than zero.");
            
            if (!WithdrawMoney(amount))
                throw new InvalidOperationException("Insufficient funds.");

            addressee.GiveMoney(amount);

            return new TransferTransaction(
              TransactionType.Transfer,
              DisplayNames[TransactionType.Transfer],
              DateTime.Now,
              Id,
              Name,
              GenerateMessage
              (
                  TransactionType.Transfer,
                  Name,
                  addressee.Name,
                  amount
              ),
              amount,
              addressee.Id,
              addressee.Name
            );
        }
    }
}
