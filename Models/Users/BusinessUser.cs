using SealBank.Constants;
using SealBank.Interfaces;
using SealBank.Models.Transactions;
using SealBank.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SealBank.Models.Users
{
    public class BusinessUser
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
    ) : UserBase
        (
            id, name, surname, gender, birthDay, 
            email, passwordHash, salt, phoneNumber, userType, balance, history
        )
    {
   
    }
}
