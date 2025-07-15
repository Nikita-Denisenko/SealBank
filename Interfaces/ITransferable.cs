using SealBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.Interfaces
{
    internal interface ITransferable
    {
        public Transaction Transfer(UserBase addressee, decimal amount);
    }
}
