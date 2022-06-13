class Ninja : Human
{
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    public Ninja(string name) : base(name)
    {
        Dexterity = 175;
    }
    // Build Attack method
    public override int Attack(Human target)
    {
        int dmg = Dexterity * 5;
        target.Health -= dmg;
        Random bnsdmg = new Random();
        int roll = bnsdmg. Next(5);
        if (roll == 2)
        {
            target.Health -= 10;
            Console.WriteLine($"{Name} rolled bonus damage on {target.Name} for {10} damage. ");
        }
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage. ");
        return target.Health;
    }
    public int Steal(Human target)
    {
        //Reduces a target humans health by 5 and add this amount to its own health
        target.Health -= 5;
        Health +=5;
        Console.WriteLine($"{Name} stole health from {target.Name} and heals for 5 health.");
        return target.Health;
    }
}