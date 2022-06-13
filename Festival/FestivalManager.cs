namespace MyApp;

public class FestivalManager
{
    public FestivalManager()
    {
        Plannables = new List<IPlannable>();
        cancellation = new CancellationTokenSource();
    }


    private CancellationTokenSource cancellation;
    private List<IPlannable> Plannables { get; }

    public async Task Start()
    {
        await Task.WhenAll(BeginPlannables(), EndPlannables());
    }

    private DateTime _programStart = DateTime.Now;
    private const int ffFactor = 50000;
    private DateTime Now()
    {
        // return fast forward time
        return _programStart.AddSeconds((DateTime.Now - _programStart).TotalSeconds * ffFactor); // multiply to fastforward
    }

    private async Task BeginPlannables()
    {
        foreach (var plannable in Plannables.OrderBy(x => x.Begin))
        {
            int delay = Math.Max(0, (int)(plannable.Begin - Now()).TotalMilliseconds / ffFactor);
            await Task.Delay(delay, cancellation.Token);
            if (cancellation.IsCancellationRequested)
            {
                break;
            }
            plannable.Start();
        }
    }

    private async Task EndPlannables()
    {
        foreach (var plannable in Plannables.OrderBy(x => x.End))
        {
            int delay = Math.Max(0, (int)(plannable.End - Now()).TotalMilliseconds / ffFactor);
            await Task.Delay(delay, cancellation.Token);
            if (cancellation.IsCancellationRequested)
            {
                break;
            }
            plannable.Stop();
        }
    }

    public void Add(IPlannable plannable)
    {
        Plannables.Add(plannable);
    }

    public void Stop()
    {
        cancellation.Cancel();
        foreach(var plannable in Plannables)
        {
            plannable.Stop();
        }
    }
}