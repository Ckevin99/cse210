using System;

public class ReflectionActivity : Activity{
    private string[] prompts;

    
    public ReflectionActivity(){
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _activityname = "Reflection Activity";

    }
    public void Reflection(){
        Console.Clear();
        Console.WriteLine("Get Ready...");
        WaitAnimation(4);
        GetrandomPrompt();
        DisplayPromts();
        Console.ReadLine();
        Console.WriteLine("Now ponder on each the following questions as they are related to this experience.");


    }
    private void GetrandomPrompt(){
        prompts = System.IO.File.ReadAllLines("reflectionPrompts.txt");
        Console.WriteLine(prompts.Count());
        


    }
    public void DisplayPromts(){
        Random random = new Random();
        int rand = random.Next(0,prompts.Count()-1);
        Console.WriteLine($"Consider the following prompt:\n\n–––{prompts[rand]}–––\n\nWhen you have something in mind, press enter to continue.");

    }


















}