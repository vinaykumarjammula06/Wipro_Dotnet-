using System;

class Person
{
    private string firstName;
    private string lastName;
    private string emailAddress;
    private DateTime dateOfBirth;

    public Person(string firstName, string lastName, string emailAddress, DateTime dateOfBirth)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.emailAddress = emailAddress;
        this.dateOfBirth = dateOfBirth;
    }

    // Read-only Property
    public bool IsAdult
    {
        get
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;

            if (DateTime.Now < dateOfBirth.AddYears(age))
                age--;

            return age >= 18;
        }
    }

    // Read-only Property
    public bool IsBirthDay
    {
        get
        {
            return (DateTime.Now.Day == dateOfBirth.Day &&
                    DateTime.Now.Month == dateOfBirth.Month);
        }
    }

    // Read-only Property
    public string ScreenName
    {
        get
        {
            return (firstName + lastName +
                   dateOfBirth.ToString("MMddyy")).ToLower();
        }
    }

    // Read-only Property
    public string SunSign
    {
        get
        {
            int day = dateOfBirth.Day;
            int month = dateOfBirth.Month;

            if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
                return "Aries";
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
                return "Taurus";
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
                return "Gemini";
            else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
                return "Cancer";
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                return "Leo";
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
                return "Virgo";
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
                return "Libra";
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
                return "Scorpio";
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
                return "Sagittarius";
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
                return "Capricorn";
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
                return "Aquarius";
            else
                return "Pisces";
        }
    }

    public void Display()
    {
        Console.WriteLine("First Name   : " + firstName);
        Console.WriteLine("Last Name    : " + lastName);
        Console.WriteLine("Email        : " + emailAddress);
        Console.WriteLine("Date of Birth: " + dateOfBirth.ToShortDateString());
        Console.WriteLine("Is Adult     : " + IsAdult);
        Console.WriteLine("Birthday     : " + IsBirthDay);
        Console.WriteLine("Sun Sign     : " + SunSign);
        Console.WriteLine("Screen Name  : " + ScreenName);
    }
}

class Employee : Person
{
    public double Salary { get; set; }

    public Employee(string firstName, string lastName, string email,
                    DateTime dob, double salary)
        : base(firstName, lastName, email, dob)
    {
        Salary = salary;
    }

    public void DisplayEmployee()
    {
        Display();
        Console.WriteLine("Salary       : " + Salary);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter First Name: ");
        string first = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string last = Console.ReadLine();

        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        Console.Write("Enter Date of Birth (dd/MM/yyyy): ");
        DateTime dob = Convert.ToDateTime(Console.ReadLine());

        Console.Write("Enter Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Employee emp = new Employee(first, last, email, dob, salary);

        Console.WriteLine("\nEmployee Details");
        Console.WriteLine("--------------------------");
        emp.DisplayEmployee();
    }
}