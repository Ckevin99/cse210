using System;
using System.Diagnostics;

public class ReflectionActivity : Activity{
    private string[] _prompts;
    private string[] _questions;
    private List<int> choosed = new List<int>();

    
    public ReflectionActivity()
    {
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _activityName = "Reflection Activity";

    }
    public void Reflection()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        WaitAnimation(4);
        GetRandomPrompt();
        DisplayPrompts();
        Console.ReadLine();

        Console.WriteLine("Now ponder on each the following questions as they are related to this experience.");
        GetRandomQuestion();
        CountDown(5,"You may begin in: ");

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        Console.Clear();

        while(stopwatch.ElapsedMilliseconds<_duration*1000)
        {
            Console.WriteLine();
            DisplayQuestions();
            WaitAnimation(10);
   
        }
 
        Console.WriteLine();




    }
    private void GetRandomPrompt()
    {
        _prompts = System.IO.File.ReadAllLines("reflectionPrompts.txt");
        
        


    }
    private void GetRandomQuestion()
    {
        _questions = System.IO.File.ReadAllLines("reflectionQuestions.txt");


    }
    private void DisplayPrompts()
    {
        Random random = new Random();
        int rand = random.Next(0,_prompts.Count()-1);
        Console.WriteLine($"Consider the following prompt:\n\n–––{_prompts[rand]}–––\n\nWhen you have something in mind, press enter to continue.");

    }
    private void DisplayQuestions()
    {
        Random random = new Random();
        int rand;
        do
        {
            rand = random.Next(0,_questions.Count());

            if(choosed.Count()==_questions.Count())
            {
                choosed.Clear();
            }   
        }while(choosed.Contains(rand));
        choosed.Add(rand);
        
        Console.Write($"> {_questions[rand]}");

    }



















}