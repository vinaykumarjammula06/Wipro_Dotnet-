using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[10];

        Console.WriteLine("Enter 10 integers:");

        for (int i = 0; i < 10; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Descending Order (Bubble Sort)
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9 - i; j++)
            {
                if (arr[j] < arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nElements in Descending Order:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(arr[i] + " ");
        }

        int max = arr[0];
        int min = arr[0];
        int sum = 0;

        for (int i = 0; i < 10; i++)
        {
            if (arr[i] > max)
                max = arr[i];

            if (arr[i] < min)
                min = arr[i];

            sum += arr[i];
        }

        Console.WriteLine("\n\nMaximum Value = " + max);
        Console.WriteLine("Minimum Value = " + min);
        Console.WriteLine("Sum = " + sum);
    }
}