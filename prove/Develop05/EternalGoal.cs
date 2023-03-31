using System;




class EternalGoal: Goal{


  public EternalGoal(string goalName, int points, string goalDescription):base(goalName, points, goalDescription){
    _goalName = goalName;
    _points = points;
    _goalDescription = goalDescription;
  }



  public override bool IsComplete(){

  return true;
  }
  public override int RecordEvent(){

    return 1;
  }











}