class Program
{
    static void Main()
    {
        // Приклад використання
        Road road = new Road { Length = 10, Width = 3, NumberOfLanes = 2, TrafficLevel = 2 };

        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Vehicle { Type = "Car", Speed = 60, Size = 1.5 },
            new Vehicle { Type = "Truck", Speed = 40, Size = 3.0 },
            new Vehicle { Type = "Bus", Speed = 50, Size = 2.5 }
        };

        TrafficSimulation simulation = new TrafficSimulation();
        simulation.SimulateTraffic(road, vehicles);
    }
}
