using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext _context;

        public AccountRepository(BankingDbContext context)
        {
            _context = context;
        }

        public void AddAccount(Account account)
        {
            _context.Accounts.Add(account);
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _context.Accounts;
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
