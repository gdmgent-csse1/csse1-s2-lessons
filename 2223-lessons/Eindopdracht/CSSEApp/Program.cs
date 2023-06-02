using System.Text;
using CSSEClass;

internal partial class Program
{
    private static void Main(string[] args)
    {

        // Starten van de applicatie...
    
        // Geef de keuze welke operatie men wil uitvoeren.
        /*
            Operaties die mogelijk zijn:
            1 - Multiplication table
            2 - Sum
            3 - Substraction
            4 - Division
            5 - Multiplication
            6 - Modulo
            7 - Exponentiation
            8 - Area Triangle
            9 - Area Rectangle
            10 - Area Square
            11 - Area Parallellogram
            12 - Area Rhombus
            13 - Area Trapezium
            14 - Area Circle
            15 - Perimeter Triangle
            16 - Perimeter Rectangle
            17 - Perimeter Square
            18 - Perimeter Parallellogram
            19 - Perimeter Rhombus
            20 - Perimeter Trapezium
            21 - Perimeter Circle
            22 - Volume Cube
            23 - Volume Cylinder
            24 - Contacts
        */

        if (args.Length != 0)
        {
            // Parameter doorgegeven...
            Console.WriteLine("Length of args: " + args.Length);
            if(args.Length > 1)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine("Arugement " + i  + ": " + args[i]);    
                }
            }
            else
            {
                Console.WriteLine("First argument: " + args[0]);
            }
            
        }
        else
        {
            // Opties weergeven...
            PrintOperations();
            // Loop starten...
            SelectOperation();
        }

        

        

        

        

        Console.WriteLine("Hello, World!");
        CSSEClass.MathOperations.Test();
        CSSEClass.MathOperations.MultiplicationTable(2, true, true);
        Console.WriteLine(CSSEClass.MathOperations.Sum(2.8, 1.5));
        Console.WriteLine(CSSEClass.MathOperations.Substraction(2.8, 1.5));
        CSSEClass.Generator.RandomNumber();
    }

    private static void PrintOperations()
    {
        // Opties weergeven...
        StringBuilder sb = new StringBuilder();
        sb.Append("Overview of operations:\n");
        sb.Append("- - - - - - - - - - - - - - - - - - - - - - - - - \n\n");
        sb.Append("1 - Multiplication table\n");
        sb.Append("2 - Sum\n");
        sb.Append("3 - Substraction\n");
        sb.Append("4 - Division\n");
        sb.Append("5 - Multiplication\n");
        sb.Append("6 - Modulo\n");
        sb.Append("7 - Exponentiation\n");
        sb.Append("8 - Area Triangle\n");
        sb.Append("9 - Area Rectangle\n");
        sb.Append("10 - Area Square\n");
        sb.Append("11 - Area Parallellogram\n");
        sb.Append("12 - Area Rhombus\n");
        sb.Append("13 - Area Trapezium\n");
        sb.Append("14 - Area Circle\n");
        sb.Append("15 - Perimeter Triangle\n");
        sb.Append("16 - Perimeter Rectangle\n");
        sb.Append("17 - Perimeter Square\n");
        sb.Append("18 - Perimeter Parallellogram\n");
        sb.Append("19 - Perimeter Rhombus\n");
        sb.Append("20 - Perimeter Trapezium\n");
        sb.Append("21 - Perimeter Circle\n");
        sb.Append("22 - Volume Cube\n");
        sb.Append("23 - Volume Cylinder\n");
        sb.Append("24 - Contacts\n");
        sb.Append("\n");
        sb.Append("- - - - - - - - - - - - - - - - - - - - - - - - - \n\n");
        sb.Append("Which operation do you want to excecute? Enter the number and confirm with enter! \n");
        sb.Append("");
        Console.WriteLine(sb);
    }

    public static void SelectOperation()
    {
        // Selections...
        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("Selected: 1 - Multiplication table\n");
                //CSSEClass.MathOperations.MultiplicationTable());
                break;
            case "2":
                Console.WriteLine("Selected: 2 - Sum\n");
                break;
            case "3":
                Console.WriteLine("Selected: 2 - Sum\n");
                break;
            case "4":
                Console.WriteLine("Selected: 2 - Sum\n");
                break;
            case "5":
                Console.WriteLine("Selected: 2 - Sum\n");
                break;
            case "6":
                Console.WriteLine("Selected: 2 - Sum\n");
                break;
            case "7":
                Console.WriteLine("Selected: 2 - Sum\n");
                break;
            case "8":
                Console.WriteLine("Selected: 2 - Sum\n");
                break;
            case "9":
                Console.WriteLine("Selected: 2 - Sum\n");
                break;
            case "10":
                Console.WriteLine("Selected: 2 - Sum\n");
                break;
            case "11":
                Console.WriteLine("Selected: 2 - Sum\n");
                break;
            case "12":
                Console.WriteLine("Selected: 2 - Sum\n");
                break;
            case "13":
                Console.WriteLine("Selected: 2 - Sum\n");
                break;
            case "14":
                Console.WriteLine("Selected: 2 - Sum\n");
                break;
            case "15":
                Console.WriteLine("Selected: 2 - Sum\n");
                break;
            case "16":
                Console.WriteLine("Selected: 2 - Sum\n");
                break;
            case "17":
                Console.WriteLine("Selected: 2 - Sum\n");
                break;
            case "18":
                Console.WriteLine("Selected: 2 - Sum\n");
                break;
            case "19":
                Console.WriteLine("Selected: 2 - Sum\n");
                break;
            case "20":
                Console.WriteLine("Selected: 2 - Sum\n");
                break;
            case "21":
                Console.WriteLine("Selected: 2 - Sum\n");
                break;
            case "22":
                Console.WriteLine("Selected: 2 - Sum\n");
                break;
            case "23":
                Console.WriteLine("Selected: 2 - Sum\n");
                break;
            case "24":
                Console.WriteLine("Selected: 2 - Sum\n");
                // Checken files
                // Uitlezen van files
                // Bewaren in objecten
                // Operatie: wijzigen contact en zijn gegevens
                // Operatie: verwijderen van contact en zijn gegevens
                // Operatie: wegschrijven/opslaan van contacten en zijn gegevens
                // Operatie: aanmaken van een contact
                // ...
                break;
            default:
                LogOutput("Selected operation unknown!");
                PrintOperations();
                SelectOperation();
                
                break;
        }
    }

    public static string GetParameter(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine();
    }

    public static void GetContacts()
    {

    }

    public static void LogOutput(string message)
    {
        throw new NotImplementedException();
    }



}