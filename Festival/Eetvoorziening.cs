namespace MyApp;

public class Eetvoorziening : Voorziening, IPlannable
{

    public DateTime Begin { get; set; }
    public DateTime End { get; set; }
    public virtual void Start()
    {
        Console.WriteLine("Open tent");
        Console.WriteLine("Doe de stroom aan");
        Console.WriteLine($"{DateTime.Now.ToShortDateString()} om {DateTime.Now.ToShortTimeString()}, gepland {Begin.ToShortDateString()} om {Begin.ToShortTimeString()}: eetvoorziening {Omschrijving} start nu (locatie: '{Locatie}')");
    }

    

    public void Stop()
    {
        if (this is HamburgerTent)
        {
            Console.WriteLine("Doe de frituur uit");
        }
        else if (this is SushiTest)
        {
            Console.WriteLine("Gooi de rijst weg");
        }
        else
        {
            Console.WriteLine("Sluit de tap af");
        }
        Console.WriteLine("Stroom uit");
        Console.WriteLine("Tent dicht");
        Console.WriteLine($"{DateTime.Now.ToShortDateString()} om {DateTime.Now.ToShortTimeString()}, gepland {End.ToShortDateString()} om {End.ToShortTimeString()}: eetvoorziening {Omschrijving} stopt nu (locatie: '{Locatie}')");
    }

}
