using MoneyService.Database.Entities;

namespace MoneyService.Database
{
    public interface IMoneyRepository
    {
        void CreateExpense(ExpenseEntity expense);
        List<ExpenseEntity> GetExpenses();
    }
}