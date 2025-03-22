namespace console_expense_tracker.Code;

public static class MenuManager
{
    internal static void ShowMainMenu()
    {
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Welcome to the Expense Tracker! Please type ONE option below: ");
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("1. Adds expense where you enter the amount, category, description, and date (optional: uses current date if not provided)");
        Console.WriteLine("2. View Expense");
        Console.WriteLine("3. Filter Expenses by date or category");
        Console.WriteLine("4. Calculate Total Expenses");
        Console.WriteLine("5. Close the program");
        Console.WriteLine("------------------------------------------------------------");
        Console.Write("Chosen option (enter a number): ");
    }
    
    // TODO: Implement a feature where a new menu appears for creating an expense
    internal static void ShowExpenseMenu()
    {
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Welcome to the Add Expense Menu! Enter an amount: ");
        Console.WriteLine("------------------------------------------------------------");
    }
    
    
}