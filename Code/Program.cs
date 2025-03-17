namespace console_expense_tracker.Code;

public static class Program
{
    private static int _chosenOption;
    internal static bool NotExited = true;
    
    private static void Main()
    {
        while (NotExited)
        {
            MenuManager.ShowMainMenu();
            GetInput();
            MenuController.ChangeMenu(_chosenOption);
        }
        Environment.Exit(0);
    }
    
    // Checks if the userInput is a number and a number between 1 and 5
    private static bool CheckValidInput(string? userInput, out int number)
    {
        if (int.TryParse(userInput, out number))
        {
            return number is >= 1 and <= 5;
        }
        return false;
    }

    private static void GetInput()
    {
        var userInput = Console.ReadLine();

        while (!CheckValidInput(userInput, out _chosenOption))
        {
            Console.Write("Sorry! Not a valid input! Please choose a number between 1 and 5: ");
            userInput = Console.ReadLine();
        }
    }
}