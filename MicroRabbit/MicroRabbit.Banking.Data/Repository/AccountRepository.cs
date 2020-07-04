using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDBContext _ctx;
        public AccountRepository(BankingDBContext context)
        {
            _ctx = context;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts;
        }
    }
}
