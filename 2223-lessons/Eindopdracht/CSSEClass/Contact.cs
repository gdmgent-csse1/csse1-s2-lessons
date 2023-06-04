/*
30. Contacten
Voorzie de nodige klassen voor het opslaan van Contacten (naam, voornaam, adres, telefoonnummers, e-mailadressen, website,...).
Adres en Telefoonnummer is een aparte klasse.

Je kan via de applicatie contacten toevoegen, uitlezen, aanpassen en verwijderen

Elk contact ga je wegschrijven naar een tekstbestand, gebruik van "txt" is hierbij voldoende.
Bij het opstarten van het programma ga je alle files inlezen (GetFiles kan hierbij helpen) en opslaan in datacollectie.
Je kan items in de datacollectie aanpassen door een zoekactie uit te voeren.
*/

using System.Text;

public class Contact : ILogging
{

    /*
    Voorzie de velden die nodig zijn voor het bewaren van de gegevens van een contact.
    Gegevens:
     - Naam
     - Voornaam
     - Adres
     - Telefoonnummers
     - E-mailadressen
     - Website
    */

    private string naam;
    private string voornaam;
    
    private Adres adres;
    private List<Telefoonnummer> telefoonnummers;
    private string[] emailadressen;

    private string website;

    // Properties
    // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    /*
        Voorzie hier de properties die nodig zijn voor de verschillende velden van een contact.
    */
    // Property Naam van het type string voor het opvullen en opvragen van het veld naam, ook van het type string.
    public string Naam
    {
        get{ return this.naam; }
        set{ this.naam = value; }
    }
    // Property Voornaam van het type string voor het opvullen en opvragen van het veld voornaam, ook van het type string.
    public string Voornaam
    {
        get{ return this.voornaam; }
        set{ this.voornaam = value; }
    }

    // Property nog voorzien voor Adres...

    // Property Telefoonnummers van het type List van Telefoonnummer voor het opvullen en opvragen van het veld telefoonnummers, ook van het type List met objecten van het type Telefoonnummer
    public List<Telefoonnummer> Telefoonnummers
    {
        get{ return this.telefoonnummers; }
        set{ this.telefoonnummers = value; }
    }
    // Property nog voorzien voor Emailadressen...

    // Property Website van het type string voor het opvullen en opvragen van het veld website, ook van het type string.
    public string Website
    {
        get{ return this.website; }
        set{ this.website = value; }
    }

    // Constructor
    // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    // Hierbij de default constructor voor het aanmaken van een object Contact.
    public Contact()
    {}

    // Hierbij de constructor waar we alle waarden gaan meegeven die nodig zijn voor de velden/properties van een object Adres.
    public Contact(string n, string fn, Adres a, string[] emails, List<Telefoonnummer> t, string w)
    {
        this.Naam = n;
        this.Voornaam = fn;
        // Voorzie het nodige voor het adres...
        // Voorzie het nodige voor de e-mailadressen...
        this.Telefoonnummers = t;
        this.Website = w;
    }

    // Methods
    // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    // DumpContent is de functie die we gaan gebruiken voor het teruggeven van een string waarin alle inhoud zit, met de 
    // waarde van de verschillende properties, deze functie kan je dan gebruiken om de gegevens weg te schrijven naar een 
    // tekstbestand.
    public string DumpContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Naam: " + this.Naam + "\n");
        sb.Append("Voornaam: " + this.Voornaam + "\n");
        // Voorzie ook het nodige voor de andere velden...
        // Adres...
        // E-mailadressen...
        foreach (Telefoonnummer item in this.Telefoonnummers)
        {
            sb.Append("Telefoonnummer; Type: " + item.Type + "; Nummer: " + "voorzie hier het nummer nog!!!" + "\n");
        }
        sb.Append("Website: " + this.Website + "\n");
        LogOutput(sb.ToString());
        return sb.ToString();
    }

    public void WriteContact()
    {
        // Wegschrijven naar een txt (tekstbestand van het type txt).
        // Hierbij de variabele voor het huidige pad aan te roepen aangevuld met daarbij Contacts, zodat de txt's allemaal in een aparte map Contacts komen te staan.
        string docPath = Directory.GetCurrentDirectory() + "\\Contacts";
            // Wegschrijven van de string array naar de nieuwe file met de naam van het contact.
        using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, this.Naam + "_" + this.Voornaam + ".txt")))
        {
            outputFile.Write(DumpContent());
            LogOutput("DumpContent of contact to TXT file completed!");
        }
    }

    // LogOutput is de implementatie van de interface ILogging, deze methode gaan we gebruiken voor output 
    // weg te schrijven naar de console.
    public void LogOutput(string message)
    {
        Console.WriteLine(message);
    }
}