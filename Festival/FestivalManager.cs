namespace MyApp;

public class FestivalManager
{
    public FestivalManager()
    {
        Plannables = new List<IPlannable>();
        
    }

    private List<IPlannable> Plannables { get; }
    private List<Voorziening> Voorzieningen { get; }

    public void Start()
    {
        foreach (var plannable in Plannables)
        {
            plannable.Start();
        }
        OpenVoorzieningen();
    }

    public void OpenVoorzieningen()
    {
        foreach (var voorziening in Voorzieningen)
        {
            if (voorziening is IPlannable)
            {
                (voorziening as IPlannable)!.Start();
            }
        }
    }

    public void Stop()
    {
        foreach (var plannable in Plannables)
        {
            plannable.Stop();
        }
    }
}