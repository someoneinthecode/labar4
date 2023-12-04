public class Vehicle : IDriveable
{
    public string Type { get; set; }
    public double Speed { get; set; }
    public double Size { get; set; }

    public void Move()
    {
        Console.WriteLine($"{Type} is moving.");
    }

    public void Stop()
    {
        Console.WriteLine($"{Type} has stopped.");
    }
}
