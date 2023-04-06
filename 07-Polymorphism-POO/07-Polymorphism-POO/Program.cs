
Animal[] animals = new Animal[3];
animals[0] = new Animal("Animal", 1);
animals[1] = new Dog("Fido", 5, "Labrador");
animals[2] = new Cat("Garfield", 3, 0.60);

foreach (Animal animal in animals)
{
    animal.MakeSound();
}


class Animal
{
    protected string Name;
    protected int Age;

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("El animal hace un sonido");
    }
}

class Dog : Animal
{
    private string Breed;

    public Dog(string name, int age, string breed) : base(name, age)
    {
        Breed = breed;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} ladra");
    }
}

class Cat : Animal
{
    private double Height;

    public Cat(string name, int age, double height) : base(name, age)
    {
        Height = height;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} maulla");
    }
}
