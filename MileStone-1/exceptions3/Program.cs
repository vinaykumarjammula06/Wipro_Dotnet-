using System;

class Person
{
    public string FirstName;
    public string LastName;
    public string EmailAddress;
    public DateTime DateOfBirth;

    public Person(string firstName, string lastName, string email, DateTime dob)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            throw new Exception("First Name should not be empty.");

        if (string.IsNullOrWhiteSpace(lastName))
            throw new Exception("Last Name should not be empty.");

        foreach (char ch in firstName)
        {
            if (!char.IsLetter(ch))
                throw new Exception("First Name should contain only alphabets.");
        }

        foreach (char ch in lastName)
        {
            if (!char.IsLetter(ch))
                throw new Exception("Last Name should contain only alphabets.");
        }

        FirstName = firstName;
        LastName = lastName;
        EmailAddress = email;
        DateOfBirth = dob;
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Email Address: ");
            string email = Console.ReadLine();

            Console.Write("Enter Date of Birth (yyyy-MM-dd): ");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());

            Person p = new Person(firstName, lastName, email, dob);

            Console.WriteLine("\nPerson Details");
            Console.WriteLine("First Name : " + p.FirstName);
            Console.WriteLine("Last Name  : " + p.LastName);
            Console.WriteLine("Email      : " + p.EmailAddress);
            Console.WriteLine("Date of Birth : " + p.DateOfBirth.ToShortDateString());
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Date Format.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}