using System;

public class BreathingActivity : Activity{

    public BreathingActivity(){
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _activityname = "Breathing Activity";
    }

    public void Breathing(){
        Console.Clear();
        Console.WriteLine("Get Ready...");
        WaitAnimation(4);
        Console.Clear();
        int runtimes = _duration/10; 
        int times = 0;
        do{
        times++;
        CountDown(4,"Breathe in...");
        CountDown(6,"Now Breathe out...");
        }while(runtimes>times);
        DisplayEndMessage();

    }


















}