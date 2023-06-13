using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square square = new Square("Red", 3);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Blue", 3, 5);
        shapes.Add(rectangle);

        Circle circle = new Circle("Purple", 3);
        shapes.Add(circle);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"Color: {color}\nArea of shape: {area}\n");
        }
    }
}