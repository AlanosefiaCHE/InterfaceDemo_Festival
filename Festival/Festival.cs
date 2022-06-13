using System.ComponentModel.DataAnnotations;

namespace MyApp;

public class Festival : IPlannable
{
    public List<Optreden> Optredens { get; }
    public FestivalMap Map { get; }
    public FestivalManager Manager{ get; }
    public Festival(DateTime begin, DateTime end)
    {
        Begin = begin;
        End = end;
        Optredens = new List<Optreden>();
        Map = new FestivalMap();
        Manager = new FestivalManager();
    }
    public void AnnuleerOptreden(string artiest)
    {
        Optreden? optreden = Optredens.Where(optreden => optreden.Artiest == artiest).FirstOrDefault();
        if(optreden != null)
        {
            optreden.Stop(); // als ie bezig is, moet ie stoppen
            Optredens.Remove(optreden);
        }
    }

    public Optreden Book(string artiest, string podium, DateTime start)
    {
        var optreden = new Optreden(artiest, podium, start);
        Optredens.Add(optreden);
        Manager.Add(optreden);
        return optreden;
    }

    public string GetMap()
    {
        return Map.GetMap();
    }

    public DateTime Begin { get; set; }
    public DateTime End { get; set; }
    public async Task Start()
    {
        Console.WriteLine("Festival start!");
        await Manager.Start();
    }

    public void Stop()
    {
        Console.WriteLine("Festival stopt!");
        Manager.Stop();
    }

    void IPlannable.Start()
    {
        _ = this.Start();
    }
}