internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Test.Tester();
        Tafel tafel1 = new Tafel();
        tafel1.Test();
        Tafel tafel2 = new Tafel("grote tafel", 10);
        tafel2.Test();

        Computer c1 = new Computer();
        c1.pcType = "Laptop";
        //...
        Laptop lpt1 = new Laptop("13 inch","HP Probook");
        Console.WriteLine("Type: " + lpt1.pcType + "; Display: " + lpt1.Display);
    
    }
}


public class Computer
{
    public string pcType;

    public Computer()
    {
    }

    public Computer(string pc)
    {
        this.pcType = pc;
    }


}

public class Laptop : Computer
{
    private string display;

    public string Display
    {
         get { return display;}
        set { display = value;}
    }

    public Laptop()
    {}
    public Laptop(string displ, string pc) : base (pc)
    {
        this.display = displ;
        //base.pcType = 
    }
}

/*
public class Desktop : Computer
{
    public Desktop()
    {}

    public Desktop()
    {

    }

}
*/

public class Tafel
{
    // velden/fields
    private string naam;
    private int aantalPoten;
    private int aantalPlaatsen;
    // eigenschappen van onze tafel...

    // properties
    public int AantalPoten
    {
        get { return aantalPoten;}
        set { aantalPoten = value;}
    }

    public string Kleur
    {
        get;
        set;
    }

    // Constructor
public Tafel()
    {
    } 
    public Tafel(string naam, int aantalPlaatsen)
    {
        this.naam = naam;
        this.aantalPlaatsen = aantalPlaatsen;
    }

    public Tafel(string naam, int aantalPlaatsen, int aantalPoten, string kleur)
    {
        this.naam = naam;
        this.aantalPlaatsen = aantalPlaatsen;
        this.AantalPoten = aantalPoten;
        this.Kleur = kleur;
    }

    // Methodes

    public void Test()
    {
        Console.WriteLine("Test van de Tafel");
    }

}

public class Test
{
    public static void Tester()
    {
        Console.WriteLine("Test!");
    }
}
