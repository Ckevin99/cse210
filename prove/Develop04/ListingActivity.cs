using System;
using System.Diagnostics;

public class ListingActivity : Activity{
    string[] _prompts;
    List<string> _listedItems = new List<string>();


public ListingActivity(){
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _activityname = "Listing Activity";
        

    }

public void Listing(){
        Console.Clear();
        Console.WriteLine("Get Ready...");
        WaitAnimation(4);
        GetRandomPrompt();
        DisplayPrompts();
        CountDown(5,"You may begin in: ");
        Counting(_duration);
        
}

public void Counting(int maxtime){

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        Console.WriteLine();
        while(stopwatch.ElapsedMilliseconds<maxtime*1000){
        Console.Write(">");
        _listedItems.Add(Console.ReadLine());
        }
        Console.WriteLine($"You listed {_listedItems.Count()} items!");
        

    }



private void DisplayPrompts(){
        Random random = new Random();
        int rand = random.Next(0,_prompts.Count()-1);
        Console.WriteLine($"Consider the following prompt:\n\n–––{_prompts[rand]}–––\n\nWhen you have something in mind, press enter to continue.");

    }
private void GetRandomPrompt(){
        _prompts = System.IO.File.ReadAllLines("listPrompts.txt");
        
        


    }

}
