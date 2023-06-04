public interface ILogging
{
    /*
        Hierbij voorzien we een abstracte methode LogOutput die één parameter heeft van het type string.
        Wanneer men een contrcat aangaat voor de interface te implementeren dan zal je voor alle abstracte methodes ook
        een implementatie moeten voorzien in de klasse die de interface precies implementeert.
        Jullie dienen dit te voorzien in de klassen:
            - Adres
            - Contact
            - Telefoonnummer
    */
    void LogOutput(string message);
}