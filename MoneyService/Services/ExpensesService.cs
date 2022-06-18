using MoneyService.Dto;

namespace MoneyService.Services
{
    public class ExpensesService : IExpensesService
    {
        public List<ExpenseDto> GetExpenses()
        {
            return new List<ExpenseDto>
            {
                new ExpenseDto("Bus ticket", 41),
                new ExpenseDto("Chiefburger", 150),
                new ExpenseDto("Internet", 800)
            };
        }
    }
}
