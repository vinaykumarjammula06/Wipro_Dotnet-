using System;

class Program
{
    static void Main(string[] args)
    {
        string username = "vinay";
        string password = "123";

        int attempts = 0;

        while (attempts < 3)
        {
            Console.Write("Enter Login: ");
            string user = Console.ReadLine();

            Console.Write("Enter Password: ");
            string pass = Console.ReadLine();

            if (user == username && pass == password)
            {
                Console.WriteLine("Login Successful!");
                return;
            }
            else
            {
                attempts++;
                Console.WriteLine("Invalid Login or Password.");

                if (attempts < 3)
                {
                    Console.WriteLine("Attempts Left: " + (3 - attempts));
                }
            }
        }

        Console.WriteLine("You have been rejected after 3 wrong attempts.");
    }
}