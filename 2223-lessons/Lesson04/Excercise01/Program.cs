internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Welke bewerking gaan we uitvoeren?");
        //Addition
        // input 1
        // input 2
        // Substraction
        // input 1
        // input 2

        string calculationCommand = Console.ReadLine();

        if (calculationCommand == "Addition")
        {
            Console.WriteLine("Geef een waarde voor het eerste getal?");
            double i1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geef een waarde voor het tweede getal?");
            double i2 = Convert.ToDouble(Console.ReadLine());
            //Addition(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Resultaat van Addition: " + i1 + " + " + i2 + " = " +Addition(i1, i2));
        } else if (calculationCommand == "Substraction")
        {
            Console.WriteLine("Substraction...");
        }

        if (true)
        {
            
        }
/*
        Console.WriteLine("Addition 5.0 + 3.0 = " + Addition(5.0, 3.0));
        double result = Addition(1.0, 2.0);
        double g1 = 1.0;
        Console.WriteLine("Addition");
        double i1 = Convert.ToDouble(Console.ReadLine());
        Double i2;
        Int32 int1;
        int int2;
        Addition(1.0, 3.5, 8.0);
        */
    }

    //Addition(+)
    private static double Addition(double input1, double input2)
    {
        return input1 + input2;
    }

    private static double Addition(double input1, double input2, double input3)
    {
        return input1 + input2 + input3;
    }

    private static double Substraction(double input1, double input2)
    {
        return input1 - input2;
    }

    //Substraction
    //Multiplication
    //...
}