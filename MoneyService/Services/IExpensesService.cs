using MoneyService.Dto;
using MoneyService.Entities;

namespace MoneyService.Services
{
    public interface IExpensesService
    {
        List<ExpenseEntity> GetExpenses();
    }
}