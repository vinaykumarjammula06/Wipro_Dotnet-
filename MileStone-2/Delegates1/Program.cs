using System;

// Declare Delegate
public delegate void MathOperation(int a, int b);

class Calculator
{
    // Addition
    public void Add(int a, int b)
    {
        Console.WriteLine("Addition = " + (a + b));
    }

    // Subtraction
    public void Subtract(int a, int b)
    {
        Console.WriteLine("Subtraction = " + (a - b));
    }

    // Multiplication
    public void Multiply(int a, int b)
    {
        Console.WriteLine("Multiplication = " + (a * b));
    }

    // Division
    public void Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Division by zero is not possible.");
        }
        else
        {
            Console.WriteLine("Division = " + (a / b));
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator obj = new Calculator();

        MathOperation del;

        Console.Write("Enter First Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");

        Console.Write("\nEnter Your Choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                del = obj.Add;
                del(num1, num2);
                break;

            case 2:
                del = obj.Subtract;
                del(num1, num2);
                break;

            case 3:
                del = obj.Multiply;
                del(num1, num2);
                break;

            case 4:
                del = obj.Divide;
                del(num1, num2);
                break;

            default:
                Console.WriteLine("Invalid Choice");
                break;
        }

        Console.ReadLine();
    }
}