using System.Drawing;

namespace AbstractClass.Entities;

public abstract class Shape
{
    public Color color { get; set; }

    public Shape(Color color)
    {
        this.color = color;
    }

    public abstract double Area();
}