using System;

class Person
{
    public string FirstName;
    public string LastName;

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

class HourlyEmployee : Person
{
    public double HoursWorked;
    public double PayPerHour;

    public HourlyEmployee(string firstName, string lastName,
                          double hoursWorked, double payPerHour)
        : base(firstName, lastName)
    {
        HoursWorked = hoursWorked;
        PayPerHour = payPerHour;
    }

    public double CalculatePay()
    {
        return HoursWorked * PayPerHour;
    }

    public void Display()
    {
        Console.WriteLine("\nHourly Employee");
        Console.WriteLine("Name: " + FirstName + " " + LastName);
        Console.WriteLine("Hours Worked: " + HoursWorked);
        Console.WriteLine("Pay Per Hour: " + PayPerHour);
        Console.WriteLine("Salary: " + CalculatePay());
    }
}

class PermanentEmployee : Person
{
    public double BasicSalary;
    public double HRA;
    public double DA;
    public double Tax;
    public double NetPay;
    public double TotalPay;

    public PermanentEmployee(string firstName, string lastName,
                             double basicSalary)
        : base(firstName, lastName)
    {
        BasicSalary = basicSalary;
    }

    public void CalculateSalary()
    {
        HRA = BasicSalary * 0.15;
        DA = BasicSalary * 0.10;
        TotalPay = BasicSalary + HRA + DA;
        Tax = TotalPay * 0.08;
        NetPay = TotalPay - Tax;
    }

    public void Display()
    {
        Console.WriteLine("\nPermanent Employee");
        Console.WriteLine("Name: " + FirstName + " " + LastName);
        Console.WriteLine("Basic Salary: " + BasicSalary);
        Console.WriteLine("HRA: " + HRA);
        Console.WriteLine("DA: " + DA);
        Console.WriteLine("Tax: " + Tax);
        Console.WriteLine("Net Pay: " + NetPay);
    }
}

class Program
{
    static void Main(string[] args)
    {
        HourlyEmployee h = new HourlyEmployee("Vinay", "Kumar", 40, 500);
        h.Display();

        PermanentEmployee p = new PermanentEmployee("Rahul", "Sharma", 50000);
        p.CalculateSalary();
        p.Display();
    }
}