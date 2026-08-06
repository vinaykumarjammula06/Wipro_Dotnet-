using System;
using System.Collections.Generic;

class Employee
{
    public int EmployeeID;
    public string EmployeeName;
    public string Department;
    public double Salary;

    public Employee(int id, string name, string dept, double salary)
    {
        EmployeeID = id;
        EmployeeName = name;
        Department = dept;
        Salary = salary;
    }

    public void Display()
    {
        Console.WriteLine("Employee ID   : " + EmployeeID);
        Console.WriteLine("Employee Name : " + EmployeeName);
        Console.WriteLine("Department    : " + Department);
        Console.WriteLine("Salary        : " + Salary);
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> empList = new List<Employee>();

        Console.Write("Enter Number of Employees: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nEnter Employee " + (i + 1) + " Details");

            Console.Write("Employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Department: ");
            string dept = Console.ReadLine();

            Console.Write("Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            empList.Add(new Employee(id, name, dept, salary));
        }

        Console.WriteLine("\nEmployee Details");

        foreach (Employee emp in empList)
        {
            emp.Display();
        }
    }
}