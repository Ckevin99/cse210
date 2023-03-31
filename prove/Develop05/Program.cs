using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        string userinput;
        List<Goal> goals = new List<Goal>();
        
        do{
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
        Console.WriteLine("Select a choice from the menu:");
        userinput = Console.ReadLine();

        switch(userinput){

        case "1": 
        Console.WriteLine("Select a kind of goal:\n1- Simple Goal\n2- EternalGoal\n3- CheckList Goal");
        userinput = Console.ReadLine();
        string goalname;
        string goaldesc;
        int goalpoints;
        int requiredReps;
        int bonus;

        switch(userinput)
        {

            case "1": 
            Console.WriteLine("What is the goal name?");
            goalname = Console.ReadLine();
            Console.WriteLine("Give a short description about the goal.");
            goaldesc = Console.ReadLine();
            Console.WriteLine("How much points to fullfiling this goal?");
            goalpoints = int.Parse(Console.ReadLine());
            
            SimpleGoal simplegoal = new SimpleGoal(goalname, goalpoints, goaldesc);

            goals.Add(simplegoal);


            break;
            case "2":
            Console.WriteLine("What is the goal name?");
            goalname = Console.ReadLine();
            Console.WriteLine("Give a short description about the goal.");
            goaldesc = Console.ReadLine();
            Console.WriteLine("How much points to fullfiling this goal?");
            goalpoints = int.Parse(Console.ReadLine());
            
            EternalGoal eternalgoal = new EternalGoal(goalname, goalpoints, goaldesc);

            goals.Add(eternalgoal);

            break;
            case "3":
            Console.WriteLine("What is the goal name?");
            goalname = Console.ReadLine();
            Console.WriteLine("Give a short description about the goal.");
            goaldesc = Console.ReadLine();
            Console.WriteLine("How much points to fullfiling this goal?");
            goalpoints = int.Parse(Console.ReadLine());
            Console.WriteLine("How many times to accomplish for bonus?");
            requiredReps = int.Parse(Console.ReadLine());
            Console.WriteLine("Bonus for accomplishing all");
            bonus = int.Parse(Console.ReadLine());
            
            CheckListGoal checklistgoal = new CheckListGoal(goalname, goalpoints, goaldesc, requiredReps, bonus);
            goals.Add(checklistgoal);

            break;
            default:
            break;
        }


        break;
        case "2":
            MyGoals mygoals = new MyGoals(goals);

            mygoals.DisplayGoals();

        break;
        case "3":

        break;

        case "4":
        break;

        case "5":
        break;

        case "6":
        break;

        default:
        Console.WriteLine("\nPlease, Type a number in the menu\n");

        break;


        }

        }while(userinput!="6");
       
    }
    
}
