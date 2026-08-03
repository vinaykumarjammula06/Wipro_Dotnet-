using System;

class Program
{
    static void Main(string[] args)
    {
        int num1, num2;

        Console.Write("Enter num1: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter num2: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nInitial Values");
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);

        // 1. Pre-increment
        num2 = ++num1;
        Console.WriteLine("\nAfter Pre-Increment");
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);

        // Reset values
        Console.Write("\nEnter num1 again: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter num2 again: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        // 2. Post-increment
        num2 = num1++;
        Console.WriteLine("\nAfter Post-Increment");
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);

        // 3. Swap values
        int temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("\nAfter Swapping");
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);
    }
}