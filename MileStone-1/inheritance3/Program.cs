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
        double total = BasicSalary + hra + da;
        double tax = total * 0.08;

        return total - tax;
    }
}

class Program
{
    static void Main(string[] args)
    {
        HourlyEmployee h = new HourlyEmployee(40, 500);
        PermanentEmployee p = new PermanentEmployee(50000);

        Console.WriteLine("Hourly Employee Salary: " + h.CalculatePay());
        Console.WriteLine("Permanent Employee Salary: " + p.CalculatePay());
    }
}