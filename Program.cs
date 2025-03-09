namespace console_expense_tracker;

public static class Program
{
    private static int _chosenOption;
    private static void Main()
    {
        ShowMenu();
        GetInput();
        ChangeMenu(_chosenOption);
    }

    private static void ShowMenu()
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

    private static bool CheckValidInput(string? userInput)
    {
        if (int.TryParse(userInput, out _))
        {
            return (int.Parse(userInput) >= 1 && int.Parse(userInput) <= 5);
        }
        return false;
    }

    private static void GetInput()
    {
        var userInput = Console.ReadLine();

        while (!CheckValidInput(userInput))
        {
            Console.Write("Sorry! Not a valid input! Please choose a number between 1 and 5: ");
            userInput = Console.ReadLine();
        }
        
        if (userInput is not null)
        {
            _chosenOption = int.Parse(userInput);
        }
    }

    private static void ChangeMenu(int chosenOption)
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
                Environment.Exit(0);
                break;
        }
    }


}