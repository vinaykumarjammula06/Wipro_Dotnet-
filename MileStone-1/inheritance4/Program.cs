using System;

interface IPayable
{
    double CalculatePay();
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("IPayable interface created with CalculatePay() method.");
    }
}