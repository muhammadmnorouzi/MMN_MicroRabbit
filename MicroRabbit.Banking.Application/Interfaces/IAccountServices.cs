using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Application.Interfaces
{
    public interface IAccountServices
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransfer accountTransfer);
        void AddAccount(Account account);
        bool SaveChanges();
    }
}
