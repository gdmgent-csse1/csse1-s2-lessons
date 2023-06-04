public class Telefoonnummer : ILogging
{
    // Fields
    // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    /*
        Voorzie hier de velden voor het bewaren van een telefoonnummer welke bestaat uit:
        Type en het telefoonnummer zelf.
        Voorbeelden
        - GSM: 0496123456
        - Privé vaste lijn: 054123456
        - Telefoon werk: 092348600
    */
    private string type; 
    // Veld nog voorzien voor nummer...

    // Properties
    // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    /*
        Voorzie hier de properties die nodig zijn voor de verschillende velden van een telefoonnummer.
    */
    // Property Type van het type string voor het opvullen en opvragen van het veld type, ook van het type string.
    public string Type
    {
        get{ return this.type; }
        set{ this.type = value; }
    }
    // Property nog voorzien voor Nummer...

     // Constructor
    // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    // Hierbij de default constructor voor het aanmaken van een object Telefoonnummer.
    public Telefoonnummer()
    {}

    // Hierbij de constructor waar we alle waarden gaan meegeven die nodig zijn voor de velden/properties van een object Telefoonnummer.
    public Telefoonnummer(string type)
    {
        this.Type = type;
        // Voorzie hierbij nog het nodige voor de andere velden in te vullen via de properties...
        // Denk aan Nummer...
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