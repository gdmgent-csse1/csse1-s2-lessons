namespace CSSEClass;

public class Generator
{
    public static int RandomNumber()
    {
        Random rnd = new Random();
        int output = rnd.Next();
        Console.WriteLine("RandomNumber() - output: " + output);
        return output;
    }

    public static int RandomNumber(int start)
    {
        //Random rnd = new Random();
        //int output = rnd.Next(start, 2147483647);
        //Console.WriteLine("RandomNumber(int start) - output: " + output);
        return RandomNumber(start, 2147483647);
    } 
    public static int RandomNumber(int start, int stop)
    {
        Random rnd = new Random();
        int output = rnd.Next(start, stop);
        Console.WriteLine("RandomNumber(int start, int stop) - output: " + output);
        return output;
    }

    public static int[] RandomNumbers(int amountOfNumbers)
    {
        // array van ints...
        int[] test = new int[3];
        Random rnd = new Random();
        for (int i = 0; i < amountOfNumbers; i++)
        {
            // item toevoegen tot array
            Console.WriteLine("Random getal is: " + rnd.Next());
        }
        // return van de array van ints...
        return test;
    }

    public static void RandomNumbers(int amountOfNumbers, int minValue, int maxValue)
    {
        Random rnd = new Random();
        for (int i = 0; i < amountOfNumbers; i++)
        {
            Console.WriteLine("Random getal is: " + rnd.Next(minValue, maxValue));
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

}