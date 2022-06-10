namespace MyApp;

public interface IPlannable
{
    DateTime Begin { get; set; }
    DateTime End { get; set; }
    void Start();
    void Stop();
}