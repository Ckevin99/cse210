using System;




class CheckListGoal : Goal{
    private int _atualReps;
    private int _requiredReps;
    private int _bonus;


  public CheckListGoal(string goalName, int points, string goalDescription, int requiredReps, int bonus):base(goalName, points, goalDescription){
    _goalName = goalName;
    _points = points;
    _goalDescription= goalDescription;
    _requiredReps = requiredReps;
    _bonus = bonus;
    
  }



  public override bool IsComplete(){

  return true;
  }
  public override int RecordEvent(){

    return 1;
  }











}