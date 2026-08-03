using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        Console.Write("Enter the content to write into the file: ");
        string content = Console.ReadLine();

        StreamWriter writer = new StreamWriter(fileName);

        writer.WriteLine(content);

        writer.Close();

        Console.WriteLine("File created, content written, saved and closed successfully.");
    }
}