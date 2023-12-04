public class Workstation : Computer, IConnectable
{
    public string Department { get; set; }

    public void Connect(Computer target)
    {
        Console.WriteLine($"{IPAddress} is connecting to {target.IPAddress}.");
    }

    public void Disconnect(Computer target)
    {
        Console.WriteLine($"{IPAddress} is disconnecting from {target.IPAddress}.");
    }

    public void TransferData(Computer target, string data)
    {
        Console.WriteLine($"{IPAddress} is transferring data to {target.IPAddress}: {data}");
    }
}