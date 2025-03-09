namespace console_expense_tracker.Code;

public static class MenuManager
{
    internal static void ShowMenu()
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
    internal static void LoadExpenseMenu()
    {
        
    }
    
    /// <summary>
    ///  This method changes the menu based on what number the user inputs.
    /// </summary>
    /// <example>If the user selects 1, the console menu changes to show a menu that creates a new expense</example>
    /// <param name="chosenOption">Based off the global variable _chosenOption</param>
    internal static void ChangeMenu(int chosenOption)
    {
        switch (chosenOption)
        {
            case 1:
                // TODO: Implement adding expense
                Console.WriteLine("You chose 1!");
                break;
            case 2:
                // TODO: Implement the ability to view expense
                Console.WriteLine("You chose 2!");
                break;
            case 3:
                // TODO: Be able to filter expenses
                Console.WriteLine("You chose 3!");
                break;
            case 4:
                // TODO: Calculate total expenses
                Console.WriteLine("You chose 4!");
                break;
            default:
                Console.WriteLine("You chose 5! Bye bye!");
                Program.NotExited = false;
                break;
        }
    }
}