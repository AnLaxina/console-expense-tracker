namespace console_expense_tracker.Code;

public class Expense
{
    // Make the id a static variable so that it can be accessed by ALL instances of the class
    private static int _id;
    private DateTime _expenseDate = DateTime.Today;
    private Category _category;
    private decimal _amount;
    private string? _description;

    public Expense(Category category, decimal amount, string description)
    {
        _id += 1;
        _category = category;
        _amount = amount;
        _description = description;
    }

    public decimal Amount
    {
        get => _amount;
        set
        {
            if (value >= 0)
            {
                _amount = value;
            }

            _amount = 0;
        }
    }

    public string? Description
    {
        get;
        set;
    }

    public static int Id
    {
        get;
    }

    public Category Cat
    {
        get => _category;
        set
        {
            // Checks to see if what the user enters is a valid enum type
            if (Enum.IsDefined(value))
            {
                _category = value;
            }
            
        }
    }
}