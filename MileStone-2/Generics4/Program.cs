using System;
using System.Collections.Generic;
using System.IO;

class Employee
{
    public int EmployeeID { get; set; }
    public string EmployeeName { get; set; }
    public string Designation { get; set; }
    public DateTime JoiningDate { get; set; }
    public string DepartmentName { get; set; }
}

class EmployeeData
{
    public List<Employee> EmployeeInfo { get; set; }

    public EmployeeData()
    {
        EmployeeInfo = new List<Employee>();
    }

    public void ReadEmployeeDetails()
    {
        Employee emp = new Employee();

        Console.Write("Enter Employee ID: ");
        emp.EmployeeID = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        emp.EmployeeName = Console.ReadLine();

        Console.Write("Enter Designation: ");
        emp.Designation = Console.ReadLine();

        Console.Write("Enter Joining Date (dd/MM/yyyy): ");
        emp.JoiningDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter Department Name: ");
        emp.DepartmentName = Console.ReadLine();

        EmployeeInfo.Add(emp);

        SaveToCSV();
    }

    public void SaveToCSV()
    {
        string filePath = "EmployeeDetails.csv";

        bool fileExists = File.Exists(filePath);

        using (StreamWriter sw = new StreamWriter(filePath, true))
        {
            if (!fileExists)
            {
                sw.WriteLine("EmployeeID,EmployeeName,Designation,JoiningDate,DepartmentName");
            }

            foreach (Employee emp in EmployeeInfo)
            {
                sw.WriteLine(emp.EmployeeID + "," +
                             emp.EmployeeName + "," +
                             emp.Designation + "," +
                             emp.JoiningDate.ToString("dd/MM/yyyy") + "," +
                             emp.DepartmentName);
            }
        }

        EmployeeInfo.Clear();

        Console.WriteLine("\nEmployee details saved successfully.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmployeeData obj = new EmployeeData();

        char choice;

        do
        {
            obj.ReadEmployeeDetails();

            Console.Write("\nDo you want to add another employee? (Y/N): ");
            choice = Convert.ToChar(Console.ReadLine());

        } while (choice == 'Y' || choice == 'y');

        Console.WriteLine("\nData stored successfully in EmployeeDetails.csv");
    }
}