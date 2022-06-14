namespace MyApp;

public class IjsTent : Eetvoorziening
{
    public override void Start()
    {
        base.Start();
        Console.WriteLine("Luik open.");
    }
}
