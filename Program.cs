using Humanizer;

static class Program
{
    static void Main(string[] args)
    {
        Creature person = new Creature("Alex", 1);
        Person alex = new Person(person);
        alex.setJobTitle("Programmer");

        HumanizeQuantities(alex.name, alex.houses);

        Creature cat = new Creature("Moon", 3);
        Cat moon = new Cat(cat);

        HumanizeQuantities(moon.name, moon.houses);
    }

    static void HumanizeQuantities(string name, int houses)
    {
        Console.WriteLine(name + " has " + "houses".ToQuantity(houses));
    }
}

public class Creature
{
    public string name;
    public int houses;

    public Creature(string name, int houses)
    {
        this.name = name;
        this.houses = houses;
    }
}

public class Person : Creature
{
    private string jobTitle;
    public Person(Creature creature)
        : base(creature.name, creature.houses)
    {
        this.jobTitle = "Unemployed";
    }

    public void setJobTitle(string jobTitle)
    {
        this.jobTitle = jobTitle;
    }
}

public class Cat : Creature
{
    public Cat(Creature creature)
        : base(creature.name, creature.houses)
    {

    }
}