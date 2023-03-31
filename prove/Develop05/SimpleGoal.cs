using System;




class SimpleGoal : Goal{
    
    private bool _iscomplete;


  public SimpleGoal(string goalName, int points, string goalDescription):base(goalName, points, goalDescription){
    _goalName = goalName;
    _points = points;
    _goalDescription = goalDescription;
    _iscomplete = false;

  }



  public override bool IsComplete(){

  return true;
  }
  public override int RecordEvent(){

    return 1;
  }











}