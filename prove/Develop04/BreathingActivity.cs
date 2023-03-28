using System;
using System.Diagnostics;

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
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while(stopwatch.ElapsedMilliseconds<_duration*1000){
       CountDown(4,"Breathe in...");
        CountDown(6,"Now Breathe out...");
        }
        DisplayEndMessage();
        

    }


















}