using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine("What is your first name?");
        string fname = Console.ReadLine();
        Console.WriteLine("What is your surname");
        string surname = Console.ReadLine();

        Console.WriteLine($"Your name is {surname}, {fname} {surname}");
    }
}