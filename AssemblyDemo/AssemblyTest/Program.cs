
using CalculatorLib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Calculator calc = new Calculator();
        int res = calc.add(100, 200);
        Console.WriteLine(" Sum is " + res);
        res = calc.multiply(10, 20);
        Console.WriteLine(" Multiplication is " + res);






    }
}