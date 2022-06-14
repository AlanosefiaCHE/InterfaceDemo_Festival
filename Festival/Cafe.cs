namespace MyApp;

public class Cafe : Eetvoorziening
{
    public override void Start()
    {
        base.Start();
        Console.WriteLine("Sluit de biertap aan.");
    }
}
