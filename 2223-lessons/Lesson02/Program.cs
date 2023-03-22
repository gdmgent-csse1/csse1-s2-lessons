internal class Program
{
    static double getal2 = 3;
    private static void Main(string[] args)
    {
        string test;
        int getal1 = 5;
        double getal3 = 0;
        Console.WriteLine("Hello, World!");
        Console.WriteLine("getal1: "+getal1);
        Console.WriteLine("getal2: "+getal2);
        Console.WriteLine("Geef een nieuwe waarde op voor getal 1: ");
        getal1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("getal1: "+getal1);
        Console.WriteLine("Geef een nieuwe waarde op voor getal 2: ");
        getal2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("getal2: "+getal2);
        Console.WriteLine("EINDE");

        int fahrenheitInteger = 100;
        int celsiusInteger = (fahrenheitInteger - 32) * (5/9);
        Console.WriteLine("Graden Celsius in Integer: " + celsiusInteger);
        double fahrenheitDouble = 100;
        double celsiusDouble = (fahrenheitDouble - 32) * (5.0/9.0);
        Console.WriteLine("Graden Celsius in Integer: " + celsiusDouble);
    }
}