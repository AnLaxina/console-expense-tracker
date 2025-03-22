using System.ComponentModel;

namespace console_expense_tracker.Code;

public record Expense
{
    // For the ID, I'll use a GUID instead as I think it's a perfect data structure for our use case
    private Guid _id;
    private string _description;
    private decimal _amount;
    private ExpenseCategory _category;
    private DateTime _date;

    public Expense(string description, decimal amount, ExpenseCategory category, DateTime date)
    {
        _description = description;
        _amount = amount;
        _category = category;
        _date = date;
    }
}