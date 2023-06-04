public class Adres : ILogging
{
    // Fields
    // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    /*
        Voorzie hier de velden voor het bewaren van een adres welke bestaat uit:
        Straat, nummer, postcode en gemeente
    */
    // Veld voor het opslaan van de straat.
    private string straat; 
    // Veld nog voorzien voor nummer..
    // Veld nog voorzien voor postcode...
    // Veld nog voorzien voor gemeente...
    
    // Properties
    // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    /*
        Voorzie hier de properties die nodig zijn voor de verschillende velden van een adres.
    */
    // Property Straat van het type string voor het opvullen en opvragen van het veld straat, ook van het type string.
    public string Straat
    {
        get{ return this.straat; }
        set{ this.straat = value; }
    }
    // Property nog voorzien voor Nummer...
    // Property nog voorzien voor Postcode...
    // Property nog voorzien voor Gemeente...

    // Constructor
    // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    // Hierbij de default constructor voor het aanmaken van een object Adres.
    public Adres()
    {}

    // Hierbij de constructor waar we alle waarden gaan meegeven die nodig zijn voor de velden/properties van een object Adres.
    public Adres(string straat)
    {
        this.Straat = straat;
        // Voorzie hierbij nog het nodige voor de andere velden in te vullen via de properties...
        // Denk aan Nummer, Postcode en Gemeente.
    }

    // Methods
    // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    // LogOutput is de implementatie van de interface ILogging, deze methode gaan we gebruiken voor output weg te 
    // schrijven naar de console.
    public void LogOutput(string message)
    {
        // Dit moet je nog aanpassen zodat je weg gaat schrijven naar de Console...
        throw new NotImplementedException();
    }
}