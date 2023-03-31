using System;




class MyGoals{
    List<Goal> _CurrentList = new List<Goal>(); 


    public MyGoals (List<Goal> list){
        _CurrentList = list;



    }

    public void DisplayGoals(){
 
        foreach (Goal x in _CurrentList){
  
            Console.WriteLine($". [{x.IsComplete()}] {x.DisplayName()} ({x.DisplayDesc()})");

        }

    }

























}