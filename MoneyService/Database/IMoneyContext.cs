using Microsoft.EntityFrameworkCore;
using MoneyService.Database.Entities;

namespace MoneyService.Database
{
    public interface IMoneyContext
    {
        DbSet<ExpenseEntity> Expenses { get; set; }
    }
}