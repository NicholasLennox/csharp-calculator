// 'using' only works with namespaces, cant say 'using Calculating.Calculators.SimpleCalculator;'
using Calculating.Calculators;

internal class Program
{
    private static void Main(string[] args)
    {
        // Fully referencing is wasteful, 'using' helps here
        var result = Calculating.Calculators.SimpleCalculator.Add(10,5);
        var otherResult = Calculating.Calculators.SimpleCalculator.Add(5,20);

        // Much less to write when using 'using'
        var thirdResult = SimpleCalculator.Add(20,4);
    }
}