using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine("Reversed String: " + new string(arr));

        
        Console.WriteLine("Substring from 2nd position: " + str.Substring(1));

        
        Console.Write("Enter the character to replace: ");
        char ch = Convert.ToChar(Console.ReadLine());

        string replaced = str.Replace(ch, '$');
        Console.WriteLine("Modified String: " + replaced);

        
        string copy = str;
        copy = copy + " Welcome";

        Console.WriteLine("Original String: " + str);
        Console.WriteLine("Copied & Modified String: " + copy);
    }
}