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
    public class User
    (
        int id,
        string name,
        string gender,
        DateTime birthDay,
        string email,
        string password,
        string phoneNumber,
        UserType userType
    )   : UserBase(id, name, gender, birthDay, email, password, phoneNumber, userType),
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

        public TransactionBase Transfer(UserBase addressee, decimal amount)
        {
            return new TransactionBase();
        }
    }
}
