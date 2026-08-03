using System;

class RandomHelper
{
    static Random random = new Random();

    
    public static int randint(int min, int max)
    {
        return random.Next(min, max + 1);
    }

    
    public static double randdouble(int min, int max)
    {
        return min + random.NextDouble() * (max - min);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Random Integer (1 to 10): " +
                          RandomHelper.randint(1, 10));

        Console.WriteLine("Random Double (1 to 10): " +
                          RandomHelper.randdouble(1, 10));
    }
}