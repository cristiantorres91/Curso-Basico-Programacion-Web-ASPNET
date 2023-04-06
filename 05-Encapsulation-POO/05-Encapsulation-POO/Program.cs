
Person p1 = new Person();
p1.Name = "Juan";
p1.Age = 25;

p1.HelloPerson();

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }


    public void HelloPerson()
    {
        Console.WriteLine($"Nombre: {Name}, Edad: {Age}");
        IsAdult(Age);
    }

    private void IsAdult(int age)
    {
        if (age > 18)
            Console.WriteLine("Es Adulto");
        else
            Console.WriteLine("No es Adulto");
    }

}