namespace MoneyService.Dto
{
    public class ExpenseDto
    {
        public string Name { get; }
        public int Cost { get; }

        public ExpenseDto(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
