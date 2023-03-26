using System;

public class BreathingActivity : Activity{

    public BreathingActivity(string description,string activityname){
        _description = description;
        _activityname = activityname;
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