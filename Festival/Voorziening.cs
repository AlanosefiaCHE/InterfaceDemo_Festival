namespace MyApp;

public abstract class Voorziening : ILocatable
{
    public string Locatie { get; set; }
    public string Omschrijving { get; set; }
}