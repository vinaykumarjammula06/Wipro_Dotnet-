using System;
using System.Collections.Generic;

class ServiceToken
{
    private static int id = 1000;

    public int TokenID { get; set; }
    public int Position { get; set; }
    public DateTime TicketDateTime { get; set; }
    public string Status { get; set; }

    public ServiceToken(int position)
    {
        TokenID = ++id;
        Position = position;
        TicketDateTime = DateTime.Now;
        Status = "Pending";
    }
}

class TicketManager
{
    public Queue<ServiceToken> TokenQueue { get; set; }

    public TicketManager()
    {
        TokenQueue = new Queue<ServiceToken>();
    }

    // Create Token
    public void GenerateServiceToken()
    {
        int position = TokenQueue.Count + 1;

        ServiceToken token = new ServiceToken(position);

        TokenQueue.Enqueue(token);

        Console.WriteLine("\nToken Generated Successfully.");
        Console.WriteLine("Token ID : " + token.TokenID);
    }

    // Get Next Token
    public void GetNextToken()
    {
        if (TokenQueue.Count == 0)
        {
            Console.WriteLine("\nNo Tokens Available.");
            return;
        }

        ServiceToken token = TokenQueue.Peek();

        Console.WriteLine("\nNext Token Details");
        Console.WriteLine("Token ID : " + token.TokenID);
        Console.WriteLine("Position : " + token.Position);
        Console.WriteLine("Date     : " + token.TicketDateTime);
        Console.WriteLine("Status   : " + token.Status);
    }

    // Update Token
    public void UpdateToken(int tokenId)
    {
        bool found = false;

        foreach (ServiceToken token in TokenQueue)
        {
            if (token.TokenID == tokenId)
            {
                token.Status = "Completed";
                found = true;
                Console.WriteLine("\nToken Updated Successfully.");
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("\nToken Not Found.");
        }
    }

    // Skip Token
    public void SkipToken()
    {
        if (TokenQueue.Count < 2)
        {
            Console.WriteLine("\nNot enough tokens to skip.");
            return;
        }

        ServiceToken skipped = TokenQueue.Dequeue();

        ServiceToken next = TokenQueue.Peek();

        TokenQueue.Enqueue(skipped);

        Console.WriteLine("\nSkipped Token : " + skipped.TokenID);
        Console.WriteLine("Next Token    : " + next.TokenID);
    }

    // Display All Tokens
    public void DisplayTokens()
    {
        if (TokenQueue.Count == 0)
        {
            Console.WriteLine("\nNo Tokens Available.");
            return;
        }

        Console.WriteLine("\n-----------------------------------------------");
        Console.WriteLine("ID\tPos\tDate\t\t\tStatus");
        Console.WriteLine("-----------------------------------------------");

        foreach (ServiceToken token in TokenQueue)
        {
            Console.WriteLine(token.TokenID + "\t" +
                              token.Position + "\t" +
                              token.TicketDateTime + "\t" +
                              token.Status);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        TicketManager manager = new TicketManager();

        int choice;

        do
        {
            Console.WriteLine("\n***************************************");
            Console.WriteLine("      TOKEN MANAGEMENT SYSTEM");
            Console.WriteLine("***************************************");
            Console.WriteLine("1. Create Token");
            Console.WriteLine("2. Get Next Token");
            Console.WriteLine("3. Update Token");
            Console.WriteLine("4. Skip Token");
            Console.WriteLine("5. List All Tokens");
            Console.WriteLine("6. Exit");

            Console.Write("\nEnter Your Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manager.GenerateServiceToken();
                    break;

                case 2:
                    manager.GetNextToken();
                    break;

                case 3:
                    Console.Write("Enter Token ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    manager.UpdateToken(id);
                    break;

                case 4:
                    manager.SkipToken();
                    break;

                case 5:
                    manager.DisplayTokens();
                    break;

                case 6:
                    Console.WriteLine("\nThank You...");
                    break;

                default:
                    Console.WriteLine("\nInvalid Choice.");
                    break;
            }

        } while (choice != 6);
    }
}