
Console.WriteLine("Ingrese su nombre:");
string name = Console.ReadLine();
Console.WriteLine("Ingrese su edad:");
int age = Convert.ToInt32(Console.ReadLine());

Person p1 = new Person(name!, age);

//Console.WriteLine($"Nombre: {p1.Name}, Edad: {p1.Age}");
p1.HelloPerson();

Person p2 = new Person();
p2.Name = "Juana";
p2.Age = 25;

//Console.WriteLine($"Nombre: {p2.Name}, Edad: {p2.Age}");
p2.HelloPerson();





public class Person
{
    public string Name{ get; set; }
    public int Age{ get; set; }

    //Un constructor en C# es un método especial de una clase que se utiliza para inicializar los objetos de esa clase.
    //Los constructores tienen el mismo nombre que la clase y no tienen tipo de retorno.
    public Person()
    {

    }
    public Person(string name, int age)
    {
        Name= name;
        Age = age;
    }
    //En C#, un método es una unidad de código que realiza una tarea específica y que puede ser llamada desde otro lugar en el programa.
    //Un método puede tener un conjunto de parámetros de entrada y devuelve un resultado si es necesario.
    public void HelloPerson()
    {
        Console.WriteLine($"Nombre: {Name}, Edad: {Age}");
    }


}