using SealBank.Constants;
using SealBank.Interfaces;
using SealBank.Models.Transactions;
using SealBank.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.Models
{
    public class BusinessUser
    (
        int id,
        string name,
        string gender,
        DateTime birthDay,
        string email,
        string password,
        string phoneNumber,
        UserType userType
    ) : UserBase(id, name, gender, birthDay, email, password, phoneNumber, userType),
        ITransferable

    {
        public TransactionBase Transfer(UserBase addressee, decimal amount)
        {
            return new TransactionBase();
        }
    }
}
