using System.Text;

namespace MyApp;

public class FestivalMap
{
    public List<ILocatable> Locaties { get; }

    public FestivalMap()
    {
        Locaties = new List<ILocatable>();
    }

    public void Add(ILocatable loc)
    {
        Locaties.Add(loc);
    }

    public string GetMap()
    {
        var sb = new StringBuilder();
        foreach (var loc in Locaties)
        {
            sb.AppendLine($"{loc.Omschrijving}: {loc.Locatie}");
        }

        return sb.ToString();
    }
    
}