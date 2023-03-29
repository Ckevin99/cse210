using System;
using System.Diagnostics;

public class Activity
{

    protected int _duration;
    protected string _description;
    protected string _activityName;

    public void TimeSession()
    {
        Console.Write("\nHow Long in seconds, would you like for this session?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("");
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_activityName}.\n");
        Console.WriteLine($"{_description}");
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Well Done!");
        WaitAnimation(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}.");
        WaitAnimation(5);
        Console.Clear();   
    }

    protected void WaitAnimation(int numSecondsToRun)
    {
        int spinnerCounter= 0;        

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        
        while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            spinnerCounter++;        
            switch (spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }
 
        Console.Write(" ");

    }
    protected void CountDown(int numSecondsToRun, string countDownMessage)
    {
        for (int i = numSecondsToRun; i >= 1; i--)
        {            
            Console.Write($"{countDownMessage} {i}");
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }
}