using SealBank.Constants;
using SealBank.Models.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.Models.Users
{
    public abstract class UserBase
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
        )
    {
        public int Id { get; } = id;
        public string Name { get; } = name;
        public string Surname { get; } = surname;
        public string Email { get; private set; } = email;
        public string Password { get; private set; } = password;
        public string Gender { get; } = gender;
        public DateTime BirthDay { get; } = birthDay;
        public int Age => DateTime.Today.Year - BirthDay.Year -
                  (DateTime.Today.DayOfYear < BirthDay.DayOfYear ? 1 : 0);
        public string PhoneNumber { get; private set; } = phoneNumber;
        public UserType UserType { get; private set; } = userType;
        public decimal Balance { get; private set; } = balance;
        public List<TransactionBase> History { get; private set; } = history;

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
 
    }
}
