public class Plant : LivingOrganism, IReproducible
{
    public void Reproduce()
    {
        Console.WriteLine("Plant is reproducing.");
    }
}