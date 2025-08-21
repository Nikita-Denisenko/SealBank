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
        string name,
        string surname,
        string gender,
        DateTime birthDay,
        string email,
        string password,
        string phoneNumber
    ) : UserBase
        (
            name, surname, gender, birthDay, 
            email, password, phoneNumber
        )
    {
   
    }
}
