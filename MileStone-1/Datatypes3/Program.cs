using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        string newString = "";

        foreach (char ch in str)
        {
            newString += (char)(ch + 1);
        }

        Console.WriteLine("String after incrementing each character:");
        Console.WriteLine(newString);

        Console.WriteLine("Upper Case:");
        Console.WriteLine(newString.ToUpper());

        Console.WriteLine("Lower Case:");
        Console.WriteLine(newString.ToLower());
    }
}