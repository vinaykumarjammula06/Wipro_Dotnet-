using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the array elements:");

        int count = 0;

        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            count++;
        }

        Console.WriteLine("Number of elements in the array = " + count);
    }
}