using System;
using System.Collections;

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
        SortedList employees = new SortedList();

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

            employees.Add(id, new Employee(id, name, dept, salary));
        }

        Console.WriteLine("\nEmployee Details (Sorted by Employee ID)");

        foreach (DictionaryEntry item in employees)
        {
            Employee emp = (Employee)item.Value;
            emp.Display();
        }
    }
}