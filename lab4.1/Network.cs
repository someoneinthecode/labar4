public class Network
{
    public List<Computer> Computers { get; set; }

    public Network()
    {
        Computers = new List<Computer>();
    }

    public void SimulateInteraction()
    {
        // Приклад взаємодії між комп'ютерами у мережі
        if (Computers.Count >= 2)
        {
            IConnectable source = Computers[0] as IConnectable;
            IConnectable target = Computers[1] as IConnectable;

            if (source != null && target != null)
            {
                source.Connect(Computers[1]);
                source.TransferData(Computers[1], "Sample Data");
                source.Disconnect(Computers[1]);
            }
        }
    }
}