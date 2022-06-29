using MoneyService.Dto;

namespace MoneyService.Services
{
    public interface IExpensesService
    {
        List<ExpenseDto> GetExpenses();
        void CreateExpense(ExpenseDto expense);
    }
}