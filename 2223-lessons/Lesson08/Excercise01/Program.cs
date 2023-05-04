internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        Computer c1 = new Computer();
        c1.pcType = "Laptop";
        
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