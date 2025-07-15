using SealBank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.Models
{
    internal class User
    (
        int id,
        string name,
        string gender,
        DateTime birthDay,
        string email,
        string password,
        string phoneNumber
    )   : UserBase(id, name, gender, birthDay, email, password, phoneNumber),
        ITransferable,
        IBonusReceivable
    {
        public int Seals { get; private set; } = 0;

        public Transaction Transfer(UserBase addressee, decimal amount)
        {
            return new Transaction();
        }

        public void AddSealBonus(int amount)
        {
            Seals += amount;
        }
    }
}
