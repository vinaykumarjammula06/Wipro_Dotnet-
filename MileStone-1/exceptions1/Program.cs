using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Marks in Subject 1: ");
            int m1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks in Subject 2: ");
            int m2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks in Subject 3: ");
            int m3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nStudent Name : " + name);
            Console.WriteLine("Subject 1 : " + m1);
            Console.WriteLine("Subject 2 : " + m2);
            Console.WriteLine("Subject 3 : " + m3);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Input! Please enter only integer values for marks.");
        }
    }
}