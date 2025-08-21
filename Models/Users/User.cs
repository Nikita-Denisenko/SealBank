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
        string password,
        string phoneNumber
    )   : UserBase
        (
            name, surname, gender, birthDay, 
            email, password, phoneNumber
        ),
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
    }
}
