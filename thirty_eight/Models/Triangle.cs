using System;

public class Triangle
{
    public double a;
    public double b;
    public double c;

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double Area()
    {
        double p = (a + b + c) / 2;
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return area;
    }
}
