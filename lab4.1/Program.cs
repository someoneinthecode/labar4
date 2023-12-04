class Program
{
    static void Main()
    {
        // Приклад використання
        Network network = new Network();

        // Додаємо комп'ютери до мережі
        network.Computers.Add(new Server { IPAddress = "192.168.1.1", Power = 100, OperatingSystem = "Windows", StorageCapacity = 1000 });
        network.Computers.Add(new Workstation { IPAddress = "192.168.1.2", Power = 80, OperatingSystem = "Linux", Department = "IT" });
        network.Computers.Add(new Router { IPAddress = "192.168.1.3", Power = 90, OperatingSystem = "RouterOS" });

        // Симулюємо взаємодію в мережі
        network.SimulateInteraction();
    }
}
