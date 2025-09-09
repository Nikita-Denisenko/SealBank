using SealBank.Constants;
using SealBank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SealBank.Models.Organizations
{
    public class OrganizationBase
    (
        Guid id,
        string name,
        SpendingCategoryType spendingCategory,
        decimal balance,
        List<Transaction> history,
        string email,
        string phoneNumber,
        string passwordHash,
        string passwordSalt
    ) : ITransferable

    {
        public Guid Id { get; } = id;
        public string Name { get; private set; } = name;
        public SpendingCategoryType spendingCategory { get; private set; } = spendingCategory;
        public decimal Balance { get; private set; } = balance;
        public List<Transaction> History { get; private set; } = history;
        public string Email { get; private set; } = email;
        public string phoneNumber { get; private set; } = phoneNumber;
        public string PasswordHash { get; private set; } = passwordHash;
        public string PasswordSalt { get; private set; } = passwordSalt;

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
    }
}
