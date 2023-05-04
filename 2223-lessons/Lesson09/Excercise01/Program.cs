internal class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        Computer c1 = new Computer();
        c1.Cpu = "i5";
        
        Laptop lpt1 = new Laptop("13 inch","HP Probook");
        Console.WriteLine("Type: " + lpt1.pcType + "; Display: " + lpt1.Display);
    }
}


public class Computer
{

/*Type computer (Laptop en Desktop)
OS
Memory
GPU
CPU
Power uitgedrukt in Watt
Storage uitgedrukt in GB of TB
Prijs (inclusief BTW)
Fabricatiejaar*/

    // velden
    public string pcType;
    public string os;
    public string memory;
    public string gpu;
    public string cpu;
    public string power;
    public string storage;
    public string prijs;
    public string fabricatiejaar;

    // properties
    public string PcType
    {
        get { return pcType;}
        set { pcType = value;}
    }

    public string Os
    {
        get { return os;}
        set { os = value;}
    }

    public string Memory
    {
        get { return memory;}
        set { memory = value;}
    }

    public string Gpu
    {
        get { return gpu;}
        set { gpu = value;}
    }

    public string Cpu
    {
        get { return cpu;}
        set { cpu = value;}
    }

    public string Storage
    {
        get { return storage;}
        set { storage = value;}
    }

    public string Power
    {
        get { return power;}
        set { power = value;}
    }
    public string Prijs
    {
        get { return prijs;}
        set { prijs = value;}
    }
    public string Fabricatiejaar
    {
        get { return fabricatiejaar;}
        set { fabricatiejaar = value;}
    }

    public Computer()
    {
        this.PcType = "Computer";
    }

    public Computer(string pc, string os, string memory, string cpu, string storage)
    {
        this.PcType = pc;
        this.Os = os;
        this.Memory = memory;
        this.Cpu = cpu;
        this.Storage = storage;
    }

    public Computer(string pc, string os, string memory, string gpu, string cpu, string power, string storage, string prijs, string fabricatiejaar)
    {
        this.PcType = pc;
        this.Os = os;
        this.Memory = memory;
        this.Gpu = gpu;
        this.Cpu = cpu;
        this.Power = power;
        this.Storage = storage;
        this.Prijs = prijs;
        this.Fabricatiejaar = fabricatiejaar;
    }
}

public class Laptop : Computer
{

    /*
        De properties/velden voor Laptop zijn:

        Scherm (in inch)
        Batterij (in mAh uitgedrukt)
        Gewicht (in kilogram)

        De properties/velden voor Desktop zijn:

        Uitbreidingsslots
    */

    // velden
    private string display;
    private string weight;
    private string battery;


    // properties
    public string Display
    {
        get { return display;}
        set { display = value;}
    }

    public string Weight
    {
        get { return weight;}
        set { weight = value;}
    }

    public string Battery
    {
        get { return battery;}
        set { battery = value;}
    }
    public Laptop()
    {
        base.PcType = "Laptop";
    }
    public Laptop(string displ, string weight, string pc, string os, string memory, string cpu, string storage)
    {
        base.PcType = pc;
        base.Os = os;
        base.Memory = memory;
        base.Cpu = cpu;
        base.Storage = storage;
        this.Display = displ;
        this.Weight = weight;
    }
    public Laptop(string displ, string weight, string batt, string pc, string os, string memory, string gpu, string cpu, string power, string storage, string prijs, string fabricatiejaar) : base (pc, os, memory, gpu, cpu, power, storage, prijs, fabricatiejaar)
    {
        //base.PcType = "Laptop";
        this.Display = displ;
        this.Weight = weight;
        this.Battery = batt;
    }
}

public class Desktop : Computer
{

    // velden
    private string slots;
    
    // properties
    public string Slots
    {
        get{ return slots;}
        set{ slots = value;}
    }

    // constructors

    public Desktop()
    {
        base.PcType = "Desktop";
    }

    public Desktop(string pc, string os, string memory, 
    string cpu, string storage, string slots)
    {
        base.PcType = "Desktop";
        base.Os = os;
        base.Memory = memory;
        base.Cpu = cpu;
        base.Storage = storage;
        this.Slots = slots;
    }

    public Desktop(string slots, string os, string memory, string gpu, string cpu, string power, string storage, string prijs, string fabricatiejaar) : base ("Desktop", os, memory, gpu, cpu, power, storage, prijs, fabricatiejaar)
    {
        this.Slots = slots;
    }

}