using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Square square = new Square("blue", 6);
        Console.WriteLine($"Color: {square.GetColor()}");
        Console.WriteLine($"The area of the square is: {square.GetArea()}\n");

        Rectangle rectangle = new Rectangle("red", 4, 3);
        Console.WriteLine($"Color: {rectangle.GetColor()}");
        Console.WriteLine($"The area of the rectangle is: {rectangle.GetArea()}\n");

        Circle circle = new Circle("crympson", 5);
        Console.WriteLine($"Color: {circle.GetColor()}");
        Console.WriteLine($"The area of the circle is: {circle.GetArea()}");
    }
}