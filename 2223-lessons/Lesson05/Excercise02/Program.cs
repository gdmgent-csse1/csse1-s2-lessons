internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        string input = Console.ReadLine();
        char karakter =' ';
        Console.WriteLine("Lengte is: "+ input.Length);
        if (input.Length >= 4)
        {
            karakter = Convert.ToChar(input.Substring(3,1));
        }
        else if(input.Length <= 4)
        {
            karakter = Convert.ToChar(input.Substring(0,1));
        }
        Console.WriteLine("De geselecteerde karakter is: " + karakter);
    }
}