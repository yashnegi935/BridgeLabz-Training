namespace CalculatorProblems;

public class AnimAnimal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public AnimAnimal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

public class AnimDog : AnimAnimal
{
    public AnimDog(string name, int age) : base(name, age)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} (Dog) barks: Woof Woof!");
    }
}

public class AnimCat : AnimAnimal
{
    public AnimCat(string name, int age) : base(name, age)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} (Cat) meows: Meow Meow!");
    }
}

public class AnimBird : AnimAnimal
{
    public AnimBird(string name, int age) : base(name, age)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} (Bird) chirps: Chirp Chirp!");
    }
}

public class AnimalHierarchy
{
    public static void Run()
    {
        Console.WriteLine("--- Animal Hierarchy & Polymorphism ---");

        List<AnimAnimal> animals = new List<AnimAnimal>
        {
            new AnimDog("Buddy", 3),
            new AnimCat("Whiskers", 2),
            new AnimBird("Robin", 1)
        };

        foreach (var animal in animals)
        {
            animal.MakeSound();
        }
    }
}
