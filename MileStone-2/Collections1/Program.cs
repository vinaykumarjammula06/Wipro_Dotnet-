using System;
using System.Collections;

class Employee
{
    public string EmployeeName;
    public int EmployeeID;
    public double Salary;

    public Employee(string name, int id, double salary)
    {
        EmployeeName = name;
        EmployeeID = id;
        Salary = salary;
    }
}

class EmployeeDAL
{
    // ArrayList to store employees
    private ArrayList employeeList = new ArrayList();

    // Add Employee
    public bool AddEmployee(Employee e)
    {
        employeeList.Add(e);
        return true;
    }

    // Delete Employee
    public bool DeleteEmployee(int id)
    {
        foreach (Employee emp in employeeList)
        {
            if (emp.EmployeeID == id)
            {
                employeeList.Remove(emp);
                return true;
            }
        }
        return false;
    }

    // Search Employee
    public string SearchEmployee(int id)
    {
        foreach (Employee emp in employeeList)
        {
            if (emp.EmployeeID == id)
            {
                return emp.EmployeeName;
            }
        }
        return null;
    }

    // Get All Employees
    public Employee[] GetAllEmployees()
    {
        Employee[] employees = new Employee[employeeList.Count];

        for (int i = 0; i < employeeList.Count; i++)
        {
            employees[i] = (Employee)employeeList[i];
        }

        return employees;
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmployeeDAL dal = new EmployeeDAL();

        int choice;

        do
        {
            Console.WriteLine("\n===== Employee Management =====");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Delete Employee");
            Console.WriteLine("3. Search Employee");
            Console.WriteLine("4. Display All Employees");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Employee ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Employee Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Salary: ");
                    double salary = Convert.ToDouble(Console.ReadLine());

                    Employee emp = new Employee(name, id, salary);

                    if (dal.AddEmployee(emp))
                        Console.WriteLine("Employee Added Successfully.");
                    break;

                case 2:
                    Console.Write("Enter Employee ID to Delete: ");
                    int deleteId = Convert.ToInt32(Console.ReadLine());

                    if (dal.DeleteEmployee(deleteId))
                        Console.WriteLine("Employee Deleted Successfully.");
                    else
                        Console.WriteLine("Employee Not Found.");
                    break;

                case 3:
                    Console.Write("Enter Employee ID to Search: ");
                    int searchId = Convert.ToInt32(Console.ReadLine());

                    string empName = dal.SearchEmployee(searchId);

                    if (empName != null)
                        Console.WriteLine("Employee Name: " + empName);
                    else
                        Console.WriteLine("Employee Not Found.");
                    break;

                case 4:
                    Employee[] employees = dal.GetAllEmployees();

                    if (employees.Length == 0)
                    {
                        Console.WriteLine("No Employees Available.");
                    }
                    else
                    {
                        Console.WriteLine("\nEmployee Details");
                        Console.WriteLine("-----------------------------------------");

                        foreach (Employee e in employees)
                        {
                            Console.WriteLine("ID     : " + e.EmployeeID);
                            Console.WriteLine("Name   : " + e.EmployeeName);
                            Console.WriteLine("Salary : " + e.Salary);
                            Console.WriteLine("-----------------------------------------");
                        }
                    }
                    break;

                case 5:
                    Console.WriteLine("Thank You!");
                    break;

                default:
                    Console.WriteLine("Invalid Choice.");
                    break;
            }

        } while (choice != 5);
    }
}