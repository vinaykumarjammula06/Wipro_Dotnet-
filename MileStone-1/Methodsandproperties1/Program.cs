using System;

class Employee
{
    string empName;
    decimal basicSalary;
    decimal hra, da, tax, grossPay, netPay;

    public Employee(string name, decimal salary)
    {
        empName = name;
        basicSalary = salary;
    }

    public void CalculateNetPay()
    {
        hra = basicSalary * 15 / 100;
        da = basicSalary * 10 / 100;
        grossPay = basicSalary + hra + da;
        tax = grossPay * 8 / 100;
        netPay = grossPay - tax;
    }

    public void Display()
    {
        Console.WriteLine("\nEmployee Salary Details");
        Console.WriteLine("---------------------------");
        Console.WriteLine("Employee Name : " + empName);
        Console.WriteLine("Basic Salary  : " + basicSalary);
        Console.WriteLine("HRA           : " + hra);
        Console.WriteLine("DA            : " + da);
        Console.WriteLine("Gross Pay     : " + grossPay);
        Console.WriteLine("Tax           : " + tax);
        Console.WriteLine("Net Pay       : " + netPay);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Basic Salary: ");
        decimal salary = Convert.ToDecimal(Console.ReadLine());

        Employee emp = new Employee(name, salary);

        emp.CalculateNetPay();
        emp.Display();
    }
}