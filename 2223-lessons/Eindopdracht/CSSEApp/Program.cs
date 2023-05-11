internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        CSSEClass.MathOperations.Test();
        CSSEClass.MathOperations.MultiplicationTable(2, true, true);
        Console.WriteLine(CSSEClass.MathOperations.Sum(2.8, 1.5));
        Console.WriteLine(CSSEClass.MathOperations.Substraction(2.8, 1.5));
        CSSEClass.Generator.RandomNumber();
    }
}