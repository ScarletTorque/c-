class Wizard : Human
{
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    public Wizard(string name) : base(name)
    {
        Intelligence = 25;
        Health = 50;
    }
    // Build Attack method
    public override int Attack(Human target)
    {
        //take the str * 5 subrract that from the targets hp
        int dmg = Intelligence * 5;
        target.Health -= dmg;
        Health += dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage. ");
        Console.WriteLine($"{Name} healed for {dmg} and now has {Health}");
        return target.Health;
    }
    public int Heal(Human target)
    {
        //Heals a target human by 10 * intelligence
        int Heal = Intelligence * 10;
        target.Health += Heal;
        Console.WriteLine($"{Name} healed {target.Name} for {Heal} health.");
        return target.Health;
    }
}