using SealBank.Constants;
using SealBank.Interfaces;
using SealBank.Models.Transactions;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.Models.Users
{
    public class User
    (
        string name,
        string surname,
        string gender,
        DateTime birthDay,
        string email,
        string passwordHash,
        string salt,
        string phoneNumber,
        int userTypeId,
        decimal balance,
        List<TransactionBase> history,
        int seals
    )   : UserBase
        (
            name, surname, gender, birthDay, 
            email, passwordHash, salt, phoneNumber, userTypeId, balance, history
        ),
        IBonusReceivable
    {
        public List<SpendingCategoryType> SpendingCategories { get; private set; } = [];
        public int BasicBonusPercent { get; } = 1;

        public int Seals { get; private set; } = seals;

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
