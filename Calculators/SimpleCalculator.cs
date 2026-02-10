namespace Calculating.Calculators;

public class SimpleCalculator
{
    // ===== Fields (raw storage - always private) =====

    private string _brand = "Casio";


    // ===== Constructors (initialize state) =====

    public SimpleCalculator()
    {
    }

    /// <summary>
    /// Constructor for the SimpleCalculator class that takes in a brand name.
    /// </summary>
    /// <param name="brand"></param>
    public SimpleCalculator(string brand) // Can also say string brand = "Casio" to provide defaults
    {
        _brand = brand;
    }


    // ===== Properties (controlled access to state) =====

    // Auto-property: C# generates a hidden backing field.
    // Other code can read the value, but only this class can change it.
    /// <summary>
    /// Returns the last calculated result
    /// </summary>
    public int LastResult { get; private set; }

    // Computed property: no storage, recalculated every time.
    // The => means "return this expression".
    public int DoubleLastResult => LastResult * 2; // Equivalent to just having { get; }

    // Property using a backing field.
    // get and set are accessors - they run when the property is read or assigned.
    // The arrow syntax is shorthand for:
    // get { return ... }
    // set { _brand = value; }
    /// <summary>
    /// Returns a formatted message about the brand of the calculator
    /// </summary>
    public string Brand
    {
        get => $"The brand is: {_brand}";
        set => _brand = value; // Just for demo, it makes sense to not be able to change this.
    }


    // ===== Behaviour (methods that change state) =====
    /// <summary>
    /// Adds two integers together and returns their sum.
    /// </summary>
    /// <param name="lhs">First integer</param>
    /// <param name="rhs">Second integer</param>
    /// <returns>Sum of lhs and rhs</returns>
    public int Add(int lhs, int rhs)
    {
        var result = lhs + rhs;
        LastResult = result; // object updates its internal state
        return result;
    }
}
