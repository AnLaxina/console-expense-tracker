namespace console_expense_tracker.Code;

public class Expense
{
    private int _id;
    private DateTime _expenseDate = DateTime.Today;
    private Category _category;
    private decimal _amount;
    private string _description;

    public Expense(Category category, decimal amount, string description)
    {
        _category = category;
        _amount = amount;
        _description = description;
    }

    public decimal Amount
    {
        get => _amount;
        set
        {
            if (_amount >= 0)
            {
                _amount = value;
            }

            _amount = 0;
        }
    }
}