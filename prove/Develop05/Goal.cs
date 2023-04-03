using System;



abstract class Goal
{

   protected string _goalName;
   protected string _goalDescription;
   protected int _points;


   public Goal(string goalName, int points, string goalDescription)
   {
      _goalName = goalName;
      _points = points;
      _goalDescription = goalDescription;

   
   }

   public abstract bool IsComplete();

 


   public abstract int RecordEvent();

   public string DisplayName()
   {

      return _goalName;
   }

   public string DisplayDesc()
   {

      return _goalDescription;
   }
   public int GetGoalPoints()
   {

      return _points;
   }
   public abstract int GoalKind();

   


}
