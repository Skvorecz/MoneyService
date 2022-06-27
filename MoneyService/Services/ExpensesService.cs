using MoneyService.Database;
using MoneyService.Database.Entities;

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
    }
}
