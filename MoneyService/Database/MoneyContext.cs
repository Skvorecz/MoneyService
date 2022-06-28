using Microsoft.EntityFrameworkCore;
using MoneyService.Database.Entities;

namespace MoneyService.Database
{
    public class MoneyContext : DbContext, IMoneyContext
    {
        public DbSet<ExpenseEntity> Expenses { get; set; }

        public MoneyContext(DbContextOptions<MoneyContext> options) : base(options)
        {
        }
    }
}
