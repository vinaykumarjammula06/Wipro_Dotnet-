using System;

class Area
{
    
    public double CalculateArea(double radius)
    {
        return 3.14 * radius * radius;
    }

    
    public double CalculateArea(double length, double breadth)
    {
        return length * breadth;
    }

    
    public double CalculateArea(float baseValue, float height)
    {
        return 0.5 * baseValue * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Area obj = new Area();

        
        Console.Write("Enter Radius of Circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Area of Circle = " + obj.CalculateArea(radius));

        
        Console.Write("\nEnter Length of Rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Breadth of Rectangle: ");
        double breadth = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Area of Rectangle = " + obj.CalculateArea(length, breadth));

        
        Console.Write("\nEnter Base of Triangle: ");
        float baseValue = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter Height of Triangle: ");
        float height = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Area of Triangle = " + obj.CalculateArea(baseValue, height));
    }
}