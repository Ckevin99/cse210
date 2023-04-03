using System;




class MyGoals{
    List<Goal> _currentList = new List<Goal>(); 
    


    public MyGoals()
    {
    }
    public void AddGoals(Goal goal)
    {
      _currentList.Add(goal);
    }

    public List<Goal> GetGoalList()
    {
        return _currentList;
    }

    public void SetGoalList(List<Goal> list)
    {
        _currentList = list;
    }

    public void DisplayGoals()
    {

        

        
         for (int i = 0; i < _currentList.Count(); i++ )
        {
            if (_currentList[i].IsComplete()==true)
            {

                Console.Write($"{i+1}. [X] {_currentList[i].DisplayName()} ({_currentList[i].DisplayDesc()})");

            }else
            {

               Console.Write($"{i+1}. [ ] {_currentList[i].DisplayName()} ({_currentList[i].DisplayDesc()})");

            }
            if (_currentList[i].GoalKind()==3)
            {
               Goal parent = _currentList[i];
               CheckListGoal child = (CheckListGoal)parent;
               Console.Write($" ––– Currently completed {child.GetAtualReps()}/{child.GetRequiredReps()}");
            }
            Console.WriteLine();


     
           
         }

    }












}