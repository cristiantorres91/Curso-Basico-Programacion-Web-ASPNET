//Dado que la clase Shape es abstracta y el método Area es abstracto,
//no se puede crear una instancia de Shape directamente,
//sino que se deben crear instancias de las clases hijas, como Rectangle y Circle.
Shape[] shapes = new Shape[2];
shapes[0] = new Rectangle(5, 10);
shapes[1] = new Circle(3);

foreach (Shape shape in shapes)
{
    Console.WriteLine($"Área de {shape.GetType().Name}: {shape.Area()}");
}

public abstract class Shape
{
    public abstract double Area();
}

public class Rectangle : Shape
{
    private double Width;
    private double Height;

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double Area()
    {
        return Width * Height;
    }
}

public class Circle : Shape
{
    private double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area()
    {
        // A = πr²
        return Math.PI * Math.Pow(Radius, 2);
    }
}