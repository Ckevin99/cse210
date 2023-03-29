using System;
using System.Diagnostics;

public class ListingActivity : Activity{
    private string[] _prompts;
    private List<string> _listedItems = new List<string>();


    public ListingActivity()
    {
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _activityName = "Listing Activity";
        

    }

    public void Listing()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        WaitAnimation(4);

        GetRandomPrompt();
        DisplayPrompts();
        CountDown(5,"You may begin in: ");
        Console.Write("You may begin in:   ");
        Counting(_duration);
        
    }

    private void Counting(int maxTime)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        Console.WriteLine();

        while(stopwatch.ElapsedMilliseconds<maxTime*1000)
        {
            Console.Write(">");
            _listedItems.Add(Console.ReadLine());
        }

        Console.WriteLine($"You listed {_listedItems.Count()} items!\n");
        

    }



    private void DisplayPrompts()
    {
        Random random = new Random();
        int rand = random.Next(0,_prompts.Count()-1);
        Console.WriteLine($"List as many response you can to the following prompt:\n\n–––{_prompts[rand]}–––\n");

    }
    private void GetRandomPrompt()
    {
        _prompts = System.IO.File.ReadAllLines("listPrompts.txt");
    }

}
