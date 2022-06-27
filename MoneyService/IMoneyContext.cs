using Microsoft.EntityFrameworkCore;
using MoneyService.Dto;
using MoneyService.Entities;

namespace MoneyService
{
    public interface IMoneyContext
    {
        DbSet<ExpenseEntity> Expenses { get; set; }
    }
}