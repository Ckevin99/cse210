// Exceeds requirements.
// I created a system to redeem rewards using points.
// I maked the code don't give points for assignments that already are completed.





using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        string userInput;
        string fileName;
        int userInput2;
        int currentPoints = 0;
        int oldPoints = 0;

         MyGoals mygoals = new MyGoals();
         SaveLoad saveload = new SaveLoad();
         List<Goal> currentgoals;
        
        do
        {
            Console.WriteLine($"You have {currentPoints} points\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Spend Points \n7. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();

            switch(userInput)
            {

                case "1": 
                    Console.WriteLine("Select a kind of goal:\n1- Simple Goal\n2- Eternal Goal\n3- CheckList Goal");
                    Console.WriteLine("What kind of goal would you like to create?");
                    userInput = Console.ReadLine();
                    string goalname;
                    string goaldesc;
                    int goalpoints;
                    int requiredReps;
                    int bonus;

                    switch(userInput)
                    {

                        case "1": 

                            Console.Write("What is the goal's name? ");
                            goalname = Console.ReadLine();
                            Console.Write("Give a short description about the goal. ");
                            goaldesc = Console.ReadLine();
                            Console.Write("How much points to fullfiling this goal? ");
                            goalpoints = int.Parse(Console.ReadLine());
            
                            SimpleGoal simplegoal = new SimpleGoal(goalname, goaldesc, goalpoints);
                            mygoals.AddGoals(simplegoal);

                            break;

                        case "2":

                            Console.Write("What is the goal's name? ");
                            goalname = Console.ReadLine();
                            Console.Write("Give a short description about the goal. ");
                            goaldesc = Console.ReadLine();
                            Console.Write("How much points to fullfiling this goal? ");
                            goalpoints = int.Parse(Console.ReadLine());
            
                            EternalGoal eternalgoal = new EternalGoal(goalname, goalpoints, goaldesc);
                            mygoals.AddGoals(eternalgoal);

                            break;

                        case "3":

                            Console.Write("What is the goal's name? ");
                            goalname = Console.ReadLine();
                            Console.Write("Give a short description about the goal. ");
                            goaldesc = Console.ReadLine();
                            Console.Write("How much points to fullfiling this goal? ");
                            goalpoints = int.Parse(Console.ReadLine());
                            Console.Write("How many times to accomplish for a bonus? ");
                            requiredReps = int.Parse(Console.ReadLine());
                            Console.Write("What is the bonus for accomplishing all times? ");
                            bonus = int.Parse(Console.ReadLine());
            
                            CheckListGoal checklistgoal = new CheckListGoal(goalname, goalpoints, goaldesc, requiredReps, bonus);
                            mygoals.AddGoals(checklistgoal);

                            break;

                            default:
                
                            break;
                    }
                    break;

                case "2":
                    mygoals.DisplayGoals();

                    break;
                case "3":
                    Console.Write("Please, Type the file name: ");
                    fileName = Console.ReadLine();
                    saveload.GetSave(mygoals.GetGoalList(), fileName, currentPoints);
                    saveload.SaveGoal();

                    break;

                case "4":
                    Console.Write("Please, Type the file name: ");
                    fileName = Console.ReadLine();
                    mygoals.SetGoalList(saveload.LoadGoal(fileName));
                    currentPoints = saveload.GetSavedPoints();

                    break;

                case "5":
                    oldPoints = currentPoints;
                    Console.Write("What goal do you want to record?");
                    userInput2 = int.Parse(Console.ReadLine());
                    currentgoals = mygoals.GetGoalList();
                    if (!currentgoals[userInput2-1].IsComplete()){  
                        currentPoints += currentgoals[userInput2-1].RecordEvent();
                        Console.WriteLine($"You got {currentPoints-oldPoints}! ");
                    }else{
                        Console.WriteLine("This goal is already completed");
                    }
                    
                    
                    
          
                    break;

                case "6":
                    Console.WriteLine("Select one reward:\n1- one hour of reading time - 100 Points\n2- 50$ - 1000 Points \n3- 2 Hours of gaming- 500 Points");
                    userInput2 = int.Parse(Console.ReadLine());
            
                    switch(userInput2)
                    {
                
                        case 1:

                            if (currentPoints>100)
                            {
                                currentPoints = currentPoints-100;
                                Console.WriteLine("Now you have one hour of reading time!");
                                break;
                            }

                            Console.WriteLine("You don't have points enought!");
                            break;
                
                        case 2:

                            if (currentPoints>1000)
                            {
                                currentPoints = currentPoints-1000;
                                Console.WriteLine("Now you can spend 50$!");
                                break;
                            }

                            Console.WriteLine("You don't have points enought!");
                            break;
                
                        case 3:
                            if (currentPoints>500)
                            {
                                currentPoints = currentPoints-500;
                                Console.WriteLine("Now you have 2 hours of gaming time!");
                                break;
                            }

                            Console.WriteLine("You don't have points enought!");
                            break;

                    }
        
                    break;

                case "7":

                    break;

                default:
                    Console.Write("\nPlease, Type a number in the menu\n");

                    break;


            }
        
        }while(userInput!="7");
       
    }
    
}
