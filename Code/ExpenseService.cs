namespace console_expense_tracker.Code;

public static class ExpenseService
{
    private static List<Expense> _expenses = new List<Expense>();
    
    public static bool AddExpense(string description, decimal amount, ExpenseCategory category, DateTime date)
    {
        if (description.Length == 0)
        {
            Console.WriteLine("Enter a description please!");
            return false;
        }
        if (amount < 0)
        {
            Console.WriteLine("Enter an amount that is greater than 0");
            return false;
        }

        if (date == null)
        {
            date = DateTime.Today;
            return false;
        }

        Expense newExpense = new Expense(description, amount, category, date);
        _expenses.Add(newExpense);
        return true;

    }
}