public class Ecosystem
{
    public List<LivingOrganism> Organisms { get; set; }

    public Ecosystem()
    {
        Organisms = new List<LivingOrganism>();
    }

    public void SimulateInteraction()
    {
        foreach (var organism in Organisms)
        {
            if (organism is IReproducible reproducibleOrganism)
            {
                reproducibleOrganism.Reproduce();
            }

            if (organism is IPredator predatorOrganism)
            {
                predatorOrganism.Hunt();
            }
        }
    }
}