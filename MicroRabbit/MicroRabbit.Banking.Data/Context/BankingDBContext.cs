using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Banking.Data.Context
{
    public class BankingDBContext : DbContext
    {
        public BankingDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Account> Accounts { get; set; }
    }
}
