namespace CSSEClass;

public class Generator
{
    // RandomNumber dien je nog aan te passen zodat de nodige argumenten voorzien zijn zoals gevraagd...
    public static int RandomNumber()
    {
        Random rnd = new Random();
        int output = rnd.Next();
        LogOutput("RandomNumber() - output: " + output);
        return output;
    }

    public static int RandomNumber(int start)
    {
        //Random rnd = new Random();
        //int output = rnd.Next(start, 2147483647);
        //LogOutput("RandomNumber(int start) - output: " + output);
        return RandomNumber(start, 2147483647);
    } 
    public static int RandomNumber(int start, int stop)
    {
        Random rnd = new Random();
        int output = rnd.Next(start, stop);
        LogOutput("RandomNumber(int start, int stop) - output: " + output);
        return output;
    }

    public static int[] RandomNumbers(int amountOfNumbers)
    {
        // Een array van integers, de lengte krijgen we binnen via het argument amountOfNumbers...
        int[] output = new int[3];
        Random rnd = new Random();
        for (int i = 0; i < amountOfNumbers; i++)
        {
            // Een integer toevoegen tot de array...
            // De code daarvoor dien je nog te voorzien...
            LogOutput("Random getal is: " + rnd.Next());
        }
        // Return de array waar de willekeurige getallen inzitten.
        return output;
    }

    public static void RandomNumbers(int amountOfNumbers, int minValue, int maxValue)
    {
        Random rnd = new Random();
        for (int i = 0; i < amountOfNumbers; i++)
        {
            LogOutput("Random getal is: " + rnd.Next(minValue, maxValue));
        }
    }

    public static char RandomChar()
    {
        return (char)RandomNumber(0);
    }

    public static char RandomChar(int maxValue)
    {
        return (char)RandomNumber(maxValue);
    }

    public static char RandomChar(int minValue, int maxValue)
    {
        return (char)RandomNumber(minValue, maxValue);
    }

    public static string PasswordGenerator()
    {
        // Implementatie moet hier nog voorzien worden...
        return "";
    }

    // LogOutput, deze methode gaan we gebruiken voor output weg te schrijven naar de console.
    public static void LogOutput(string message)
    {
        Console.WriteLine(message);
    }

}