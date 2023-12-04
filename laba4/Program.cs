class Program
{
    static void Main()
    {
        // Приклад використання
        Ecosystem ecosystem = new Ecosystem();

        // Додаємо організми до екосистеми
        ecosystem.Organisms.Add(new Animal());
        ecosystem.Organisms.Add(new Plant());
        ecosystem.Organisms.Add(new Microorganism());

        // Симулюємо взаємодію
        ecosystem.SimulateInteraction();
    }
}
