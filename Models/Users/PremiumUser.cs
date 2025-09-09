using SealBank.Constants;
using SealBank.Interfaces;
using SealBank.Models.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.Models.Users
{
    public class PremiumUser 
    (
        Guid id,
        string name,
        string surname,
        string gender,
        DateTime birthDay,
        string email,
        string passwordHash,
        string salt,
        string phoneNumber,
        UserType userType,
        decimal balance,
        List<TransactionBase> history
    )   : UserBase
        (
            id, name, surname, gender, birthDay, 
            email, passwordHash, salt, phoneNumber, userType, balance, history
        ),
        IBonusReceivable

    {
        public List<SpendingCategoryType> SpendingCategories { get; private set; } = [];
        public int BasicBonusPercent { get; } = 2;
        public int Seals { get; private set; } = 0;

        public List<SpendingCategoryType> ChooseCategories()
        {
            return new List<SpendingCategoryType>();
        }

        public void AddSealBonus(int amount)
        {
            Seals += amount;
        }
    }
}
