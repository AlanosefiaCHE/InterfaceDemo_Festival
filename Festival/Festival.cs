using System.ComponentModel.DataAnnotations;

namespace MyApp;

public class Festival : IPlannable
{
    public List<Optreden> Optredens { get; }
    public FestivalMap Map { get; }
    public FestivalManager Manager{ get; }
    public Festival()
    {
        Optredens = new List<Optreden>();
        Map = new FestivalMap();
        Manager = new FestivalManager();
        InitLocaties();
    }
    public bool AnnuleerOptreden(Optreden optreden)
    {
        return true;
    }

    private void InitLocaties()
    {
        var snackbar = new Eetvoorziening() {Locatie = "A1", Omschrijving = "Patat"};
        var hamburgerTent = new Eetvoorziening() {Locatie = "B5", Omschrijving = "Burgers"};
        var sushiTent = new Eetvoorziening() {Locatie = "C3", Omschrijving = "sushi"};
        Map.Add(snackbar);
        Map.Add(hamburgerTent);
        Map.Add(sushiTent);
    }
    public Optreden Book(string artiest, string podium, DateTime start)
    {
        var optreden = new Optreden(artiest, podium, start);
        Optredens.Add(optreden);
        return optreden;
    }

    public string GetMap()
    {
        return Map.GetMap();
    }

    public DateTime Begin { get; set; }
    public DateTime End { get; set; }
    public void Start()
    {
        Manager.Start();
    }

    public void Stop()
    {
        Manager.Stop();
    }
}