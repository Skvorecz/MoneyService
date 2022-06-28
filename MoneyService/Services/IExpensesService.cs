using MoneyService.Database.Entities;
using MoneyService.Dto;

namespace MoneyService.Services
{
    public interface IExpensesService
    {
        List<ExpenseEntity> GetExpenses();
        void CreateExpense(ExpenseDto expense);
    }
}