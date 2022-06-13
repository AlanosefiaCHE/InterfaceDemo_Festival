namespace MyApp;

public class Eetvoorziening : Voorziening, IPlannable
{

    public DateTime Begin { get; set; }
    public DateTime End { get; set; }
    public void Start()
    {
        Console.WriteLine($"{DateTime.Now.ToShortDateString()} om {DateTime.Now.ToShortTimeString()}, gepland {Begin.ToShortDateString()} om {Begin.ToShortTimeString()}: eetvoorziening {Omschrijving} start nu (locatie: '{Locatie}')");
    }

    public void Stop()
    {
        Console.WriteLine($"{DateTime.Now.ToShortDateString()} om {DateTime.Now.ToShortTimeString()}, gepland {End.ToShortDateString()} om {End.ToShortTimeString()}: eetvoorziening {Omschrijving} stopt nu (locatie: '{Locatie}')");
    }
}
