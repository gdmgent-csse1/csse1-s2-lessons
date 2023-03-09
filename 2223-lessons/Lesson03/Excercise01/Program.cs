internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // Maken van een methode Optelsom.
        int getal1, getal2;
        getal1 = 3;
        getal2 = 4;
        int getal3 = 5;
        OptelsomMethode(getal1, getal2);
        int resultaat = OptelsomFunctie(getal1, getal2);
        Console.WriteLine("Resultaat OptelsomFunctie met 2 parameters:" +resultaat);
        int resultaat2 = OptelsomFunctie(getal1, getal2, getal3);
        Console.WriteLine("Resultaat OptelsomFunctie met 3 parameters:" +resultaat2);
        Console.WriteLine("Resultaat OptelsomFunctie met 3 parameters:" + OptelsomFunctie(getal1, getal2, getal3));
        Console.WriteLine("Resultaat OptelsomFunctie met 3 parameters op een andere manier...:" + OptelsomFunctie(4, 5, 6));
        Console.WriteLine("Samenvoegen van woorden: " + OptelsomFunctie("dit ", "is ", "een test"));
        TafelVan1();
        TafelsVan1Tot10();
        char teken = 'a';
        teken++;
        Console.WriteLine(teken);
        AlleTekens();
        int test = 1;
        test += 1;
        Console.WriteLine("test: " + test);
    }

    public static void AlleTekens()
    {
        char teken = 'a';
        for (int i = 0; i < 40; i++)
        {
            Console.WriteLine(teken++);
        }
    }

    public static void TafelsVan1Tot10()
    {
        Console.WriteLine("--------- Tafels van 1 tot 10! -------------");
        for (int j = 1; j <= 10; j++)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(j +" x "+i+" = " + j*i);
            }
        }
    }

    public static void TafelVan1()
    {
        Console.WriteLine("--------- Tafel van 1! -------------");
        /*
        1 x 1 = 1
        1 x 2 = 2
        1 x 3 = 3
        ... 
        10
        */
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("1 x "+i+" = " + 1*i);
        }
    }

    public static void OptelsomMethode(int g1, int g2)
    {
        int resultaat = g1 + g2;
        Console.WriteLine("Resultaat OptelsomMethode:" + resultaat);
    }

    public static int OptelsomFunctie(int g1, int g2)
    {
        return g1 + g2;
    }

    public static int OptelsomFunctie(int getal1, int getal2, int getal3)
    {
        return getal1 + getal2 + getal3;
    }

    public static string OptelsomFunctie(string getal1, string getal2, string getal3)
    {
        return "" + getal1 + getal2 + getal3;
    }

    /*
    public static int OptelsomFunctie(int g1, int g2, int g3)
    {
        return g1 + g2 + g3;
    }
    */
}