using Microsoft.EntityFrameworkCore;
using MoneyService.Database.Entities;

namespace MoneyService.Database
{
    public class MoneyContext : DbContext, IMoneyContext
    {
        public DbSet<ExpenseEntity> Expenses { get; set; }

        public MoneyContext(DbContextOptions<MoneyContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ExpenseEntity>().HasData(new ExpenseEntity { Id = 1, Name = "Bus ticket", Cost = 41 },
                                                        new ExpenseEntity { Id = 2, Name = "Chiefburger", Cost = 150 },
                                                        new ExpenseEntity { Id = 3, Name = "Internet", Cost = 800 });
        }
    }
}
