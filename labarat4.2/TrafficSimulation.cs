public class TrafficSimulation
{
    public void SimulateTraffic(Road road, List<Vehicle> vehicles)
    {
        Console.WriteLine($"Simulating traffic on a road of length {road.Length} with {road.NumberOfLanes} lanes.");

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"Vehicle type: {vehicle.Type}, Speed: {vehicle.Speed}");
            vehicle.Move();
        }

        Console.WriteLine("Simulation completed.");
    }
}