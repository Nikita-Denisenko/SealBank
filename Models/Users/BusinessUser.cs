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
        string surname,
        string gender,
        DateTime birthDay,
        string email,
        string password,
        string phoneNumber,
        UserType userType,
        decimal balance,
        List<TransactionBase> history
    ) : UserBase
        (
            id, name, surname, gender, birthDay, 
            email, password, phoneNumber, userType,
            balance, history
        ),
        ITransferable

    {
        public TransferTransaction Transfer(UserBase addressee, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
