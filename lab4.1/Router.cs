public class Router : Computer, IConnectable
{
    public List<Computer> ConnectedComputers { get; set; }

    public Router()
    {
        ConnectedComputers = new List<Computer>();
    }

    public void Connect(Computer target)
    {
        ConnectedComputers.Add(target);
        Console.WriteLine($"{IPAddress} is connecting to {target.IPAddress}.");
    }

    public void Disconnect(Computer target)
    {
        ConnectedComputers.Remove(target);
        Console.WriteLine($"{IPAddress} is disconnecting from {target.IPAddress}.");
    }

    public void TransferData(Computer target, string data)
    {
        Console.WriteLine($"{IPAddress} is transferring data to {target.IPAddress}: {data}");
    }
}