using System;

interface IPayable
{
    double CalculatePay();
}

class HourlyEmployee : IPayable
{
    public double HoursWorked;
    public double PayPerHour;

    public HourlyEmployee(double hoursWorked, double payPerHour)
    {
        HoursWorked = hoursWorked;
        PayPerHour = payPerHour;
    }

    public double CalculatePay()
    {
        return HoursWorked * PayPerHour;
    }
}

class PermanentEmployee : IPayable
{
    public double BasicSalary;

    public PermanentEmployee(double basicSalary)
    {
        BasicSalary = basicSalary;
    }

    public double CalculatePay()
    {
        double hra = BasicSalary * 0.15;
        double da = BasicSalary * 0.10;
        double grossPay = BasicSalary + hra + da;
        double tax = grossPay * 0.08;
        double netPay = grossPay - tax;

        return netPay;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IPayable hourly = new HourlyEmployee(40, 500);
        IPayable permanent = new PermanentEmployee(50000);

        Console.WriteLine("Hourly Employee Pay: " + hourly.CalculatePay());
        Console.WriteLine("Permanent Employee Pay: " + permanent.CalculatePay());
    }
}