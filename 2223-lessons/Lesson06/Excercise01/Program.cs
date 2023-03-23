internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        /*
        Random rnd = new Random();
        int getal = rnd.Next();
        Console.WriteLine("Het getal is " + getal);
        
        getal = rnd.Next(5, 10);
        Console.WriteLine("Het getal is " + getal);
        Console.WriteLine("Het getal is " + rnd.Next(5, 10));
        Console.WriteLine("Het getal is " + rnd.Next(5, 10));
        Thread.Sleep(500);
        Console.WriteLine("Het getal is " + rnd.Next(5, 10));
        Thread.Sleep(500);
        Console.WriteLine("Het getal is " + rnd.Next(5, 10));
        Thread.Sleep(500);
        Console.WriteLine("Het getal is " + rnd.Next(0, 100));
        Thread.Sleep(500);
        Console.WriteLine("Het getal is " + rnd.Next(0, 100));
        Thread.Sleep(500);
        Console.WriteLine("Het getal is " + rnd.Next(0, 100));
        Thread.Sleep(500);
        Console.WriteLine("Het getal is " + rnd.Next(0, 100));
        Thread.Sleep(500);
        Console.WriteLine("Het getal is " + rnd.Next(0, 100));
        Thread.Sleep(500);
        Console.WriteLine("Het getal is " + rnd.Next(0, 100));
        Thread.Sleep(500);
        Console.WriteLine("Het getal is " + rnd.Next(0, 100));
        Thread.Sleep(500);
        Console.WriteLine("Het getal is " + rnd.Next(0, 100));
        Thread.Sleep(500);
        Console.WriteLine("Het getal is " + rnd.Next(0, 100));
        Thread.Sleep(500);
        Console.WriteLine("Het getal is " + rnd.Next(0, 100));
        Thread.Sleep(500);
        */

        /*
        Console.WriteLine("Het getal is: " + RandomInt(300));
        Console.WriteLine("Het getal is: " + RandomInt(400, 300));
        Console.WriteLine("Het getal is: " + RandomInt(40, 450, 0));
        Console.WriteLine("Het getal is: " + RandomInt(80, 210, 1000));
        Console.WriteLine("Het getal is: " + RandomInt(85, 900, 3000));
        Console.WriteLine("Het getal is: " + RandomInt(10, 52, 0));
        Console.WriteLine(" ---------------------------------------------- ");

        RandomInts(20, 20, 855, 200);

        getal = 65;
        char karakter = (char)getal;
        Console.WriteLine("Het karakter is: " + karakter);
        */
        Console.WriteLine("Het karakter is: " + RandomChar());
        // A-Z
        Console.WriteLine("Het karakter is: " + RandomChar(65, 91, 0));
        // a-z
        Console.WriteLine("Het karakter is: " + RandomChar(97, 123, 0));
        //Speciale karakters
        Console.WriteLine("Het karakter is: " + RandomChar(33, 48, 0));
        Console.WriteLine("Het karakter is: " + RandomChar(58, 65, 0));
        Console.WriteLine("Het karakter is: " + RandomChar(91, 97, 0));
        Console.WriteLine("Het karakter is: " + RandomChar(123, 127, 0));
        Console.WriteLine(" ---------------------------------------------- ");
        Console.WriteLine("Het karakter is: " + RandomSpecialChar(0));
        Console.WriteLine(" ---------------------------------------------- ");
        Console.WriteLine("Het password is: " + PasswordGenerator(9, 3, 3, 3));
    }

    public static int RandomInt(int sleepValue)
    {
         int sleep;
        if (sleepValue == 0)
        {
            sleep = 500;
        }
        else
        {
            sleep = sleepValue;
        }
        Random rnd = new Random();
        Thread.Sleep(sleep);
        return rnd.Next();
    }

    public static int RandomInt(int maxValue, int sleepValue)
    {
        int sleep;
        if (sleepValue == 0)
        {
            sleep = 500;
        }
        else
        {
            sleep = sleepValue;
        }
        Random rnd = new Random();
        Thread.Sleep(sleep);
        return rnd.Next(maxValue);
    }

    public static int RandomInt(int minValue, int maxValue, int sleepValue)
    {
        int sleep;
        if (sleepValue == 0)
        {
            sleep = 500;
        }
        else
        {
            sleep = sleepValue;
        }
        Random rnd = new Random();
        Thread.Sleep(sleep);
        return rnd.Next(minValue, maxValue);
    }

    public static void RandomInts(int amountOfInts, int minValue, int maxValue, int sleepValue)
    {
        int sleep;
        if (sleepValue == 0)
        {
            sleep = 500;
        }
        else
        {
            sleep = sleepValue;
        }

        Random rnd = new Random();
        for (int i = 0; i < amountOfInts; i++)
        { 
            Thread.Sleep(sleep);
            Console.WriteLine("Random getal is: " + rnd.Next(minValue, maxValue));
        }
    }

    public static char RandomChar()
    {
        return (char)RandomInt(0);
    }

    public static char RandomChar(int maxValue, int sleepValue)
    {
        return (char)RandomInt(maxValue, sleepValue);
    }

    public static char RandomChar(int minValue, int maxValue, int sleepValue)
    {
        return (char)RandomInt(minValue, maxValue, sleepValue);
    }

    public static char RandomSpecialChar(int sleepValue)
    {
        int specialCharGroup = RandomInt(1, 5, sleepValue);
        if (specialCharGroup == 1)
        {
            return (char)RandomInt(33, 48, sleepValue);    
        }
        else
        {
            return (char)RandomInt(58, 65, sleepValue);
        }
    }

    public static string PasswordGenerator(int passwordLength, int amountSpecialChars, int amountChars, int amountInts)
    {
        string output = "" ;
        for (int i = 0; i < amountSpecialChars; i++)
        {
            output += RandomSpecialChar(0);
        }

        for (int i = 0; i < amountChars; i++)
        {
            output += RandomChar(65, 91, 0);
        }

        for (int i = 0; i < amountInts; i++)
        {
            output += RandomInt(10, 0);
        }
        return output;
    }



}