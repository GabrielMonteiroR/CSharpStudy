using System;

public class Program
{
    public static void Main(string[] args)
    {
        Triangle triangleOne = new Triangle(3.0, 4.0, 5.0);
        double area = triangleOne.Area();
        Console.WriteLine("Área do triângulo: " + area);
    }
}
