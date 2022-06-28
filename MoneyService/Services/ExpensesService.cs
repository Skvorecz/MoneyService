using MoneyService.Database;
using MoneyService.Database.Entities;
using MoneyService.Dto;

namespace MoneyService.Services
{
    public class ExpensesService : IExpensesService
    {
        private readonly IMoneyContext context;

        public ExpensesService(IMoneyContext context)
        {
            this.context = context;
        }

        public List<ExpenseEntity> GetExpenses()
        {
            return context.Expenses.ToList();
        }

        public void CreateExpense(ExpenseDto expense)
        {
            context.Expenses.Add(new ExpenseEntity
            {
                Name = expense.Name,
                Cost = expense.Cost
            });
            context.SaveChanges();
        }
    }
}
