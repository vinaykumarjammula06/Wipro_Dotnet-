using System;

class Person
{
    public string FirstName;
    public string LastName;

    public Person(string firstName, string lastName)
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
    }

    public void Display()
    {
        Console.WriteLine("\nPerson Details");
        Console.WriteLine("First Name : " + FirstName);
        Console.WriteLine("Last Name  : " + LastName);
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine() ?? "";

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine() ?? "";

            Person p = new Person(firstName, lastName);

            p.Display();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}