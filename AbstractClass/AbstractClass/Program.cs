using System.Drawing;
using System.Globalization;
using AbstractClass.Entities;
using Rectangle = AbstractClass.Entities.Rectangle;

Console.WriteLine("Enter the number of shapes: ");
int n = int.Parse(Console.ReadLine());

List<Shape> list = new List<Shape>();

foreach (var shape in list)
{
    Console.WriteLine($"Shape #{shape} data:");
    Console.WriteLine("Rectangle or Circle (r/c)? ");
    char ch = char.Parse(Console.ReadLine());
    Console.WriteLine("Color (Black,Blue,Red)");
    Color color = Enum.Parse<Color>(Console.ReadLine());
    if (ch is 'r')
    {
        Console.WriteLine("Width: ");
        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Height: ");
        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new Rectangle(width, height, color));
    }
    else
    {
        Console.WriteLine("Radius: ");
        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new Circle(radius,color));
    }

    Console.WriteLine();
    Console.WriteLine("SHAPE AREAS:");
    foreach (var shapeO in list)
    {
        Console.WriteLine(shapeO);
    }
    
    
}
