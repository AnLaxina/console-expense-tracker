namespace console_expense_tracker.Code;

public static class MenuController
{

    internal static void HandleInput(int chosen)
    {
        var userInput = Console.ReadLine();

        switch (chosen)
        {
            case 1:
                Console.WriteLine($"You wrote {Convert.ToDecimal(userInput).ToString("C")}");
                break;
        }
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
                Console.WriteLine("You chose 1!");
                // Console.Clear();
                // Console.WriteLine("\x1b[3J");
                MenuManager.ShowExpenseMenu();
                HandleInput(chosenOption);
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