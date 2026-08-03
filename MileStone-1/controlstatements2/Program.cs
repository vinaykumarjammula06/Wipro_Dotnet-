using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number (single digit): ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 % 10 == num2)
        {
            Console.WriteLine(num2 + " is in Unit's place.");
        }
        else if ((num1 / 10) % 10 == num2)
        {
            Console.WriteLine(num2 + " is in Ten's place.");
        }
        else if ((num1 / 100) % 10 == num2)
        {
            Console.WriteLine(num2 + " is in Hundred's place.");
        }
        else if ((num1 / 1000) % 10 == num2)
        {
            Console.WriteLine(num2 + " is in Thousand's place.");
        }
        else
        {
            Console.WriteLine(num2 + " is not found in Unit, Ten, Hundred or Thousand place.");
        }
    }
}