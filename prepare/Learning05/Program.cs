using System;
using System.Linq.Expressions;
using employee_demo;
using shapes_learning;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3); // output area 9
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5); // output area 20
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6); // output area 113.04
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor(); 

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}