namespace MyApp;

public class Eetvoorziening : Voorziening, IPlannable
{
    public string Locatie { get; set; }
    public string Omschrijving { get; set; }

    public DateTime Begin { get; set; }
    public DateTime End { get; set; }
    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}