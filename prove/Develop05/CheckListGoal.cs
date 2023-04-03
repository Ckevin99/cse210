using System;




class CheckListGoal : Goal
{
  private int _atualReps;
  private int _requiredReps;
  private int _bonusPoints;
  protected int _kind;
   


  public CheckListGoal(string goalName, int points, string goalDescription, int requiredReps, int bonus):base(goalName, points, goalDescription)
  {
    _goalName = goalName;
    _points = points;
    _goalDescription= goalDescription;
    _requiredReps = requiredReps;
    _bonusPoints = bonus;
    _kind = 3;
    _atualReps = 0;
    
  }



  public override bool IsComplete()
  {
    if (_atualReps == _requiredReps)
    {
      return true;
    }else
    {
      return false;
    }
  }
  public override int RecordEvent()
  {
    if (_requiredReps>_atualReps)
    {
      int totalPoints = _points;
      _atualReps++;

      if (_requiredReps==_atualReps)
      {
        totalPoints += _bonusPoints;
      }

      return totalPoints;
    }
    
     
    return 0;
  }
  public int GetRequiredReps()
  {

    return _requiredReps;
  }
  public int GetAtualReps()
  {

    return _atualReps;
  }
  public override int GoalKind()
  {
    return _kind;
  }
  public int GetBonusPoints()
  {

    return _bonusPoints;
  }
 


}