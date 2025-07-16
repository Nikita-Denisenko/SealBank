using SealBank.Models;
using SealBank.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.Interfaces
{
    public interface ITransferable
    {
        public Transaction Transfer(UserBase addressee, decimal amount);
    }
}
