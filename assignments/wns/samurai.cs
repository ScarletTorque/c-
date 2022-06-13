class Samurai : Human
{
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    public Samurai(string name) : base(name)
    {
        Health = 200;
    }
    // Build Attack method
    public override int Attack(Human target)
    {
        if (target.Health < 50)
        {
            target.Health = 0;
            Console.WriteLine($"{Name} executed {target.Name}! {target.Name} has died.");
        }
        else
        {
            int dmg = Strength * 5;
            target.Health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage. ");
        }
        return target.Health;
    }
    public int Meditate(Human target)
    {
        Health = 200;
        Console.WriteLine($"{Name} has meditated and restored its health");
        return Health;
    }
}