using SealBank.Models.Transactions;
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
        Guid Id { get; }
        string Name { get;}
        decimal Balance { get; }
        void GiveMoney(decimal amount);
        bool WithdrawMoney(decimal amount);
    }
}
