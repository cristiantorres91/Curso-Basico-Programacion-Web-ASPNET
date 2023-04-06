Dog myDog = new Dog("Fido", 5, "Pitbull");
myDog.Eat();
myDog.Sleep();
myDog.Bark();
myDog.ShowBreed();


class Animal
{
    protected string Name;
    protected int Age;

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} está comiendo.");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} está durmiendo.");
    }
}

class Dog : Animal
{
    private string Breed;

    public Dog(string name, int age, string breed) : base(name, age)
    {
        Breed = breed;
    }

    public void Bark()
    {
        Console.WriteLine($"{Name} está ladrando.");
    }

    public void ShowBreed()
    {
        Console.WriteLine($"{Name} es de raza {Breed}");
    }
}

