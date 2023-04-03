using System;


class EternalGoal: Goal{
  protected int _kind;
 


  public EternalGoal(string goalName, int points, string goalDescription):base(goalName, points, goalDescription)
  {
    _goalName = goalName;
    _points = points;
    _goalDescription = goalDescription;
    _kind = 2;
    
  }



  public override bool IsComplete()
  {

    return false;
  }
  public override int RecordEvent()
  {

    return _points;
  }
  public override int GoalKind()
  {
    return _kind;
  }
  


}