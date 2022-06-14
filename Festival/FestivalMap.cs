using System.Runtime.Serialization;
using System.Text;

namespace MyApp;

public class FestivalMap
{
    public List<ILocatable> Locaties { get; }
    private string[] geldigeVelden = { "A", "B", "C", "D", "E", "F" };
    public FestivalMap()
    {
        Locaties = new List<ILocatable>();
    }

    public void Add(ILocatable loc)
    {
       var kwadrant = Int32.Parse(loc.Locatie.Substring(1));
        
        if (!(geldigeVelden.Contains(loc.Locatie.Substring(0, 1))
            && kwadrant >= 1 && kwadrant <= 4))
        {
            throw new InvalidLocationException();
        }
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

[Serializable]
internal class InvalidLocationException : Exception
{
    public InvalidLocationException()
    {
    }

    public InvalidLocationException(string? message) : base(message)
    {
    }

    public InvalidLocationException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected InvalidLocationException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}