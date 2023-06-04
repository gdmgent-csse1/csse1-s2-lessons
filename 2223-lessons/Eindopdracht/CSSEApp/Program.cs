using System.Text;
using CSSEClass;

internal partial class Program
{

    // Lijst van contacten.
    public static List<Contact> contacts = new List<Contact>();
    private static void Main(string[] args)
    {
        // Starten van de applicatie...
        LogOutput("Welcome to the CSSEApp!");
        LogOutput("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
        LogOutput(" .----------------.  .----------------.  .----------------.  .----------------.  .----------------.  .----------------.  .----------------. ");
        LogOutput("| .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |");
        LogOutput("| |     ______   | || |    _______   | || |    _______   | || |  _________   | || |      __      | || |   ______     | || |   ______     | |");
        LogOutput("| |   .' ___  |  | || |   /  ___  |  | || |   /  ___  |  | || | |_   ___  |  | || |     /  \\     | || |  |_   __ \\   | || |  |_   __ \\   | |");
        LogOutput("| |  / .'   \\_|  | || |  |  (__ \\_|  | || |  |  (__ \\_|  | || |   | |_  \\_|  | || |    / /\\ \\    | || |    | |__) |  | || |    | |__) |  | |");
        LogOutput("| |  | |         | || |   '.___`-.   | || |   '.___`-.   | || |   |  _|  _   | || |   / ____ \\   | || |    |  ___/   | || |    |  ___/   | |");
        LogOutput("| |  \\ `.___.'\\  | || |  |`\\____) |  | || |  |`\\____) |  | || |  _| |___/ |  | || | _/ /    \\ \\_ | || |   _| |_      | || |   _| |_      | |");
        LogOutput("| |   `._____.'  | || |  |_______.'  | || |  |_______.'  | || | |_________|  | || ||____|  |____|| || |  |_____|     | || |  |_____|     | |");
        LogOutput("| |              | || |              | || |              | || |              | || |              | || |              | || |              | |");
        LogOutput("| '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |");
        LogOutput(" '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------' ");
        LogOutput("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
        LogOutput("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
        
        // Ophalen van de bestanden uit de folder Contacts...
        // Deze dan één voor één in de lijst contacten plaatsen...
        contacts = GetContacts();
       
    
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
            24 - Generator - Random Number
            25 - Generator - Random Numbers
            26 - Generator - Random Char
            27 - Generator - Random Chars
            28 - Generator - Password Generator
            29 - Contacts
        */

        // Als er argumenten zijn meegegeven aan het exe dan dien je deze eerst uit te voerne...
        if (args.Length != 0)
        {
            // We drukken de lengte van het aantal argumenten af in de console...
            LogOutput("Length of args: " + args.Length);
            // We gaan alle argumenten overlopen en uitvoeren...
            for (int i = 0; i < args.Length; i++)
            {
                // Voer de desbetreffende operatie uit...
                LogOutput("Arugement " + i  + ": " + args[i]);
                SelectOperation(Console.ReadLine());
            }
        }
        else
        {
            // Opties weergeven...
            PrintOperations();
            // Loop starten...
            SelectOperation(Console.ReadLine());
        }
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
        sb.Append("24 - Generator - Random Number\n");
        sb.Append("25 - Generator - Random Numbers\n");
        sb.Append("26 - Generator - Random Char\n");
        sb.Append("27 - Generator - Random Chars\n");
        sb.Append("28 - Generator - Password Generator\n");
        sb.Append("29 - Contacts\n");
        sb.Append("\n");
        sb.Append("- - - - - - - - - - - - - - - - - - - - - - - - - \n\n");
        sb.Append("Which operation do you want to excecute? Enter the number and confirm with enter! \n");
        sb.Append("");
        Console.WriteLine(sb);
    }

    public static void StartAgain()
    {
        // Opties weergeven...
        PrintOperations();
        // Loop starten...
        SelectOperation(Console.ReadLine());
    }

    public static void SelectOperation(string selection)
    {
        // Selections...
        switch (selection)
        {
            case "1":
                LogOutput("Selected: 1 - Multiplication table\n");
                //CSSEClass.MathOperations.MultiplicationTable());
                break;
            case "2":
                LogOutput("Selected: 2 - Sum\n");
                // Uitvoeren van een Sum, waarbij we de twee waarden opvragen via de GetParameter functie.
                CSSEClass.MathOperations.Sum(Convert.ToDouble(GetParameter("Geef een waarde in voor getal 1: ")), Convert.ToDouble(GetParameter("Geef een waarde in voor getal 2: ")));
                break;
            case "3":
                LogOutput("Selected: 3 - Substraction\n");
                // Nog het nodige toevoegen voor de Substraction uit te voeren...
                break;
            case "4":
                LogOutput("Selected: 4 - Division\n");
                // Nog het nodige toevoegen voor de Division uit te voeren...
                break;
            case "5":
                LogOutput("Selected: 5 - Multiplication\n");
                // Nog het nodige toevoegen voor de Multiplication uit te voeren...
                break;
            case "6":
                LogOutput("Selected: 6 - Modulo\n");
                // Nog het nodige toevoegen voor de Modulo uit te voeren...
                break;
            case "7":
                LogOutput("Selected: 7 - Exponentiation\n");
                // Nog het nodige toevoegen voor de Exponentiation uit te voeren...
                LogOutput("" + CSSEClass.MathOperations.Exponentiation(2,2));
                break;
            case "8":
                LogOutput("Selected: 8 - Area Triangle\n");
                // Nog het nodige toevoegen voor de Area Triangle uit te voeren...
                break;
            case "9":
                LogOutput("Selected: 9 - Area Rectangle\n");
                // Nog het nodige toevoegen voor de Area Rectangle uit te voeren...
                break;
            case "10":
                LogOutput("Selected: 10 - Area Square\n");
                // Nog het nodige toevoegen voor de Area Square uit te voeren...
                break;
            case "11":
                LogOutput("Selected: 11 - Area Parallellogram\n");
                // Nog het nodige toevoegen voor de Area Parallellogram uit te voeren...
                break;
            case "12":
                LogOutput("Selected: 12 - Area Rhombus\n");
                // Nog het nodige toevoegen voor de Area Rhombus uit te voeren...
                break;
            case "13":
                LogOutput("Selected: 13 - Area Trapezium\n");
                // Nog het nodige toevoegen voor de Area Trapezium uit te voeren...
                break;
            case "14":
                LogOutput("Selected: 14 - Area Circle\n");
                // Nog het nodige toevoegen voor de Area Circle uit te voeren...
                LogOutput("" + CSSEClass.MathOperations.AreaCircle(Convert.ToDouble(GetParameter("Give a value for the radius?"))));
                break;
            case "15":
                LogOutput("Selected: 15 - Perimeter Triangle\n");
                // Nog het nodige toevoegen voor de Perimeter Triangle uit te voeren...
                break;
            case "16":
                LogOutput("Selected: 16 - Perimeter Rectangle\n");
                // Nog het nodige toevoegen voor de Perimeter Rectangle uit te voeren...
                break;
            case "17":
                LogOutput("Selected: 17 - Perimeter Square\n");
                // Nog het nodige toevoegen voor de Perimter Square uit te voeren...
                break;
            case "18":
                LogOutput("Selected: 18 - Perimeter Parallellogram\n");
                // Nog het nodige toevoegen voor de Perimeter Parallellogram uit te voeren...
                break;
            case "19":
                LogOutput("Selected: 19 - Perimeter Rhombus\n");
                // Nog het nodige toevoegen voor de Perimeter Rhombus uit te voeren...
                break;
            case "20":
                LogOutput("Selected: 20 - Perimeter Trapezium\n");
                // Nog het nodige toevoegen voor de Perimeter Trapezium uit te voeren...
                break;
            case "21":
                LogOutput("Selected: 21 - Perimeter Circle\n");
                // Nog het nodige toevoegen voor de Perimeter Circle uit te voeren...
                break;
            case "22":
                LogOutput("Selected: 22 - Volume Cube\n");
                // Nog het nodige toevoegen voor de Volume Cube uit te voeren...
                break;
            case "23":
                LogOutput("Selected: 23 - Volume Cylinder\n");
                // Nog het nodige toevoegen voor de Volume Cylinder uit te voeren...
                break;
            case "24":
                 LogOutput("Selected: 24 - Generator - Random Number\n");
                // Nog het nodige toevoegen voor de Generator - Random Number uit te voeren...
                break;
            case "25":
                LogOutput("Selected: 25 - Generator - Random Numbers\n");
                // Nog het nodige toevoegen voor de Generator - Random Numbers uit te voeren...
                break;
            case "26":
                LogOutput("Selected: 26 - Generator - Random Char\n");
                // Nog het nodige toevoegen voor de Generator - Random Char uit te voeren...
                break;
            case "27":
                LogOutput("Selected: 27 - Generator - Random Chars\n");
                // Nog het nodige toevoegen voor de Generator - Random Chars uit te voeren...
                break;
            case "28":
                LogOutput("Selected: 28 - Generator - Password Generator\n");
                // Nog het nodige toevoegen voor de Generator - Password Generator uit te voeren...
                break;
            case "29":
                LogOutput("Selected: 29 - Contacts\n");
                // Nog het nodige toevoegen voor de Contacts uit te voeren...
                LogOutput("a - Print all contacts");
                LogOutput("b - Add contact");
                LogOutput("c - Change contact");
                LogOutput("d - Delete contact");
                LogOutput("e - Save all contacts");
                
                string input = Console.ReadLine();
                if(input == "a")
                {
                    LogOutput("Selected: 29 - Contacts -- a - Print all contacts\n");
                    foreach (var item in contacts)
                    {
                        LogOutput(item.DumpContent());
                        LogOutput("END -- 29 - Contacts -- a - Print all contacts");
                    }
                }
                else if(input == "b")
                {
                    LogOutput("Selected: 29 - Contacts -- b - Add contact\n");
                    /*
                        Het nodige nog voorzien voor het toevoegen van een contact in de lijst van contacten.
                        Stappenplan:
                        - Stel de vragen die nodig zijn voor het aanmaken van een contact...
                        - Als alles aanwezig is van waarden in de instantie dan voeg je deze toe tot de lijst van contacts.
                        - Je gaat alles txt's wissen in de folder en dan terug alles wegschrijven vanuit de lijst contacts naar txt's.
                    */

                    /*
                        // Voorbeeld van code... welke nog niet volledig af is...
                        Console.WriteLine("Geef een naam in:");
                        string naam = Console.ReadLine();
                        List<Telefoonnummer> telefoonnumers = new List<Telefoonnummer>();
                        Console.WriteLine("Geef een telefoonnummer op: ");
                        string telefoonnummer = Console.ReadLine();
                        telefoonnumers.Add(telefoonnummer);
                        Adres a = new Adres();
                        Contact c = new Contact(naam, "", a, sbyte, telefoonnumers,...);
                        contacts.Add(c);
                    */
                }
                else if(input == "c")
                {
                    LogOutput("Selected: 29 - Contacts -- c - Change contact\n");
                    /*
                        Het nodige nog voorzien voor het wijzigen van een contact in de lijst van contacten.
                        Stappenplan:
                        - Stel de vraag welk contact je wenst te wijzigen...
                        - Voorzie eventueel de optie dat je de lijst nog eens afdrukt...
                        - Per veld ga je dan de waarde weergeven en ook de vraag stellen welke de nieuwe waarde is per veld...
                        - Na het wijzigen, ga je de optie ook uitvoeren voor het opslaan van alle contacten in txt's.
                    */
                }
                else if(input == "d")
                {
                    LogOutput("Selected: 29 - Contacts -- d - Delete contact\n");
                    /*
                        Het nodige nog voorzien voor het wissen/verwijderen van een contact in de lijst van contacten.
                        Stappenplan:
                        - Stel de vraag welk contact je wenst te wijzigen...
                        - Voorzie eventueel de optie dat je de lijst nog eens afdrukt...
                        - Je zoekt het contact in de lijst aan de hand van de parameters en je wist deze in de lijst van contacten.
                        - Na het verwijderen, ga je de optie ook uitvoeren voor het opslaan van alle contacten in txt's.
                    */
                }
                else if(input == "e")
                {
                    LogOutput("Selected: 29 - Contacts -- e - Save all contacts\n");
                    LogOutput("" + contacts.Count);
                    DeleteFiles();
                    // Loop voor het overlopen van alle contacten in de lijst contacts en elk item in de lijst ga je wegschrijven 
                    // naar een txt via de methode WriteContact.
                    foreach (var item in contacts)
                    {
                        item.WriteContact();
                        LogOutput("WriteContact - END");
                    }
                }
                break;
            default:
                LogOutput("Selected operation unknown!");
                StartAgain();
                break;
        }
        StartAgain();
    }

    public static string GetParameter(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine();
    }

    public static void DeleteFiles()
    {
        string contactsTxtPath = Directory.GetCurrentDirectory() + "\\Contacts";
        System.IO.DirectoryInfo di = new DirectoryInfo(contactsTxtPath);
        foreach (FileInfo file in di.GetFiles())
        {
            file.Delete();
        }
        /*
        foreach (DirectoryInfo dir in di.GetDirectories())
        {
            dir.Delete(true); 
        }
        */
    }

    public static List<Contact> GetContacts()
    {
        LogOutput("START - Execute GetContacts");
        List<Contact> contacts = new List<Contact>();
        // Alle files openen in de folder Contacts en ook toevoegen tot de lijst.
        string contactsTxtPath = Directory.GetCurrentDirectory() + "\\Contacts";
        string [] fileEntries = Directory.GetFiles(contactsTxtPath);
        
        foreach(string fileName in fileEntries)
            contacts = ReadFile(fileName, contacts);

        LogOutput("END - Execute GetContacts");
        LogOutput("Items in the contacts list is: " + contacts.Count);
        return contacts;
    }

    public static List<Contact> ReadFile(string filePath, List<Contact> contacts)
    {
        LogOutput("Open file " + filePath + ".");
        List<string> lines = File.ReadAllLines(filePath, Encoding.UTF8).ToList<string>();
        LogOutput("Amount of lines in the file '" + filePath + "' is: " + lines.Count);
        Contact c = new Contact();
        List<Telefoonnummer> tels = new List<Telefoonnummer>();
        List<string> emails = new List<string>();
        foreach (string line in lines)
        {
            LogOutput("The current line is: " + line);    
            // Selectie om te zien over welke waarden het gaat...
            if(line.Contains("Naam"))
            {
                LogOutput("Line contains Naam...");
                c.Naam = line.Replace("Naam: ", "");
                LogOutput("Current content: " + c.Naam);
            }
            else if (line.Contains("Voornaam"))
            {
                LogOutput("Line contains Voornaam...");
                c.Voornaam = line.Replace("Voornaam: ", "");
                LogOutput("Current content: " + c.Voornaam);
            }
            else if (line.Contains("Telefoonnummer"))
            {
                Telefoonnummer tel = new Telefoonnummer();
                LogOutput("Line contains Telefoonnummer...");
                List<string> parts = line.Split(';').ToList();
                LogOutput("Count of parts: " + parts.Count);
                foreach (string p in parts)
                {
                    LogOutput("Part of the line is: " + p);
                    if(p.Contains(" Type: "))
                    {
                        tel.Type = p.Replace(" Type: ", "");
                    }
                    else if(p.Contains(" Nummer: "))
                    {
                        //tel.Nummer
                        p.Replace(" Nummer: ", "");
                    }
                }
                tels.Add(tel);
            }
            c.Telefoonnummers = tels;
        }
        contacts.Add(c);
        LogOutput(c.DumpContent());
        return contacts;
    }

    // LogOutput, deze methode gaan we gebruiken voor output weg te schrijven naar de console.
    public static void LogOutput(string message)
    {
        Console.WriteLine(message);
    }
}