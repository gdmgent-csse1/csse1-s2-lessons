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

    public string Website
    {
        get{ return website; }
        set{ website = value; }
    }

    public List<Telefoonnummer> Telefoonnummers
    {
        get{ return telefoonnummers; }
        set{ telefoonnummers = value; }
    }

    public Contact()
    {}

    public Contact(string n, string vn, Adres a, string[] emails, List<Telefoonnummer> t, string w)
    {
        this.Website = w;
        this.Telefoonnummers = t;
    }

    public string DumpContent()
    {
        StringBuilder sb = new StringBuilder();
        //sb.Append("Naam: " + this.Naam);
        sb.Append("Website: " + this.Website);
        //...
        LogOutput(sb.ToString());
        return sb.ToString();
    }

    public void LogOutput(string message)
    {
        Console.WriteLine(message);
    }
}