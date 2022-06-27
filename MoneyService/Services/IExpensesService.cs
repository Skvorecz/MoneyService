using MoneyService.Database.Entities;

namespace MoneyService.Services
{
    public interface IExpensesService
    {
        List<ExpenseEntity> GetExpenses();
    }
}