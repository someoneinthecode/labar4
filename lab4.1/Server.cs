public class Server : Computer, IConnectable
{
    public int StorageCapacity { get; set; }

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