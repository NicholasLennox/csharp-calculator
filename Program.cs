using Calculating.Calculators;

internal class Program
{
    private static void Main(string[] args)
    {
        var simpleCalc = new SimpleCalculator("GShock");

        Console.WriteLine(simpleCalc.Brand);

        Console.WriteLine(simpleCalc.Add(10,10));

        Console.WriteLine(simpleCalc.LastResult);

        Console.WriteLine(simpleCalc.DoubleLastResult);
    }
}