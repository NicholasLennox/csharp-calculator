// dotnet run -> Program.Main
// internal -> only visible in this project (even when referenced by another project)
internal class Program
{
    // private -> only visible in enclosing block {}
    // static -> mark member (method in this case) as part of the class itself, not the instance
    private static void Main(string[] args)
    {
        /*
            For readability, we dont use the return values e.g. var result = myCalculator.Add(10,5)
        */
        Calculator myCalculator = new Calculator(); // Instance
        myCalculator.PrivateAdd(10.5); // Does not work
        myCalculator.PublicAdd(10,5); // Works
        myCalculator.StaticAdd(10,5); // Does not work (static members cannot be accessed with an instance reference)
        Calculator.StaticAdd(10,5); // Works (Calculator is a reference to the class, not an instance of it)
        Calculator.PublicAdd(10,5); // Does not work (non-static members need an instance)
    }
}

public class Calculator
{
    // Members (methods + properties/fields) are 'private' by default
    int PrivateAdd(int lhs, int rhs)
    {
        return lhs + rhs;
    }

    public int PublicAdd(int lhs, int rhs)
    {
        return lhs + rhs;
    }

    public static int StaticAdd(int lhs, int rhs)
    {
        return lhs + rhs;
    }
}