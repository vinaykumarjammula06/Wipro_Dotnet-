using System;

class Math
{
    
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }

    
    public int Divide(int a, int b)
    {
        return a / b;
    }

    public int Divide(int a, int b, int c)
    {
        return a / b / c;
    }

    
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Subtract(int a, int b, int c)
    {
        return a - b - c;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Math obj = new Math();

        
        Console.WriteLine("Addition");
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Add(a,b) = " + obj.Add(a, b));
        Console.WriteLine("Add(a,b,c) = " + obj.Add(a, b, c));

        
        Console.WriteLine("\nMultiplication");
        Console.WriteLine("Multiply(a,b) = " + obj.Multiply(a, b));
        Console.WriteLine("Multiply(a,b,c) = " + obj.Multiply(a, b, c));

        
        Console.WriteLine("\nDivision");
        Console.WriteLine("Divide(a,b) = " + obj.Divide(a, b));
        Console.WriteLine("Divide(a,b,c) = " + obj.Divide(a, b, c));

        
        Console.WriteLine("\nSubtraction");
        Console.WriteLine("Subtract(a,b) = " + obj.Subtract(a, b));
        Console.WriteLine("Subtract(a,b,c) = " + obj.Subtract(a, b, c));
    }
}