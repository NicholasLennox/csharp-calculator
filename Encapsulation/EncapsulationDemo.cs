namespace Calculating.Encapsulation;

public class EncapsulationDemo
{
    // Properties let the outside interact with state simply,
    // while the inside stays in control.
    //
    // Validation protects the state when writing,
    // and formatting gives a friendly view when reading.

    private int _myProperty;

    public int MyProperty
    {
        // Expression-bodied accessor:
        // "return the result of this method"
        get => GetMyProperty();

        // "run this method when assigning a value"
        set => SetMyProperty(value);
    }

    // A read-only "view" of the same underlying state.
    // This is derived/presentation output, not stored state.
    public string MyPropertyDisplay => FormatMyProperty();

    private int GetMyProperty()
    {
        // Return the stored value (raw state).
        return _myProperty;
    }

    private void SetMyProperty(int value)
    {
        // Validation: we decide what values are allowed into our state.
        if (value < 0)
            throw new ArgumentException("MyProperty cannot be negative.");

        _myProperty = value;
    }

    private string FormatMyProperty()
    {
        // Formatting: create a friendly string view without changing the stored value.
        return $"The value is: {MyProperty}";
    }
}
