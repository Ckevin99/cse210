using System;




class SimpleGoal : Goal{
    
    private bool _isComplete;
    protected int _kind;
  


    public SimpleGoal(string goalName, string goalDescription, int points):base(goalName, points, goalDescription)
    {
        _goalName = goalName;
        _points = points;
        _goalDescription = goalDescription;
        _isComplete = false;
        _kind = 1;


    }



    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override int RecordEvent()
    {
        if (_isComplete ==false)
        {
          _isComplete = true;
          return _points;
        }
        return 0;
    }
    public override int GoalKind()
    {
        return _kind;
    }


}