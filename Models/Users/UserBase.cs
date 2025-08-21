using SealBank.Constants;
using SealBank.Models.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SealBank.Models.Users
{
    public abstract class UserBase
        (
            string name,
            string surname,
            string gender,
            DateTime birthDay,
            string email,
            string password,
            string phoneNumber
        )
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; } = name;
        public string Surname { get; } = surname;
        public string Email { get; private set; } = email;
        public string Password { get; private set; } = password;
        public string Gender { get; } = gender;
        public DateTime BirthDay { get; } = birthDay;
        public int Age => DateTime.Today.Year - BirthDay.Year -
                  (DateTime.Today.DayOfYear < BirthDay.DayOfYear ? 1 : 0);
        public string PhoneNumber { get; private set; } = phoneNumber;
        public int UserTypeId { get; private set; } = 0;
        public decimal Balance { get; private set; } = 0;
        public List<TransactionBase> History { get; private set; } = [];

        public void GiveMoney(decimal amount)
        {
            Balance += amount;
        }

        public bool WithdrawMoney(decimal amount)
        {
            if (Balance < amount) return false;

            Balance -= amount;

            return true;
        }

        public void ChangeEmail(string newEmail) => Email = newEmail;
        public void ChangePassword(string newPassword) => Password = newPassword;

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
              "Перевод",
              DateTime.Now,
              Id,
              Name,
              $"{Name} перевёл {amount}₽ пользователю {addressee}.",
              amount,
              addressee.Id,
              addressee.Name
            );
        }
    }
}
