internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //throw new System.Exception();
        //throw new System.BadImageFormatException();
        Console.WriteLine("Na de BadImageFormatException");
        try
        {
            Console.WriteLine("Voor de AccessViolationException");
            throw new AccessViolationException();
            Console.WriteLine("Na de AccessViolationException");
        }
        catch (System.AccessViolationException)
        {
            Console.WriteLine("Start Catch blok - AccessViolationException");
            //throw;
            Console.WriteLine("Eind Catch blok - AccessViolationException");
        }
        catch (System.Exception)
        {
            Console.WriteLine("Start Catch blok - Exception");
            //throw;
            Console.WriteLine("Eind Catch blok - Exception");
        }
        
        /*
        try
        {
            throw new AbandonedMutexException();
        }
        finally
        {
            Console.WriteLine("Finally blok");
        }
        */

        try
        {
            Console.WriteLine("Geef een getal in...");
            int getal = Convert.ToInt32(Console.ReadLine());
        }
        catch (System.Exception)
        {
            Console.WriteLine("Exception is opgetreden!!!");
        }
        
        AskNumber();

/*
        Console.WriteLine("Geef een woord in...");
        string woord = Console.ReadLine();
*/

 
try


    }

    private static int AskNumber()
    {
        try
        {
            Console.WriteLine("----- We vragen een getal op - AskNumber... -----");
            Console.WriteLine("Geef een getal in...");
            return Convert.ToInt32(Console.ReadLine());  
        }
        catch
        {
           Console.WriteLine("Je hebt geen getal ingegeven, probeer opnieuw!");
           return AskNumber();
        }
    }
}