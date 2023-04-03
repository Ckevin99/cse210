using System;
using System.IO;




class SaveLoad{
    private List<Goal> _CurrentList = new List<Goal>(); 
    private string _fileName;
    private int _points;


    public SaveLoad()
    {
    }
    public void GetSave(List<Goal> list, string file, int points)
    {
        _CurrentList = list;
        _fileName = file;
        _points = points;

    }


    public void SaveGoal()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {

        outputFile.WriteLine($"{_points}");
            for (int i = 0; i < _CurrentList.Count(); i++ )
            {
                if (_CurrentList[i].GoalKind()==1)
                {
                    outputFile.WriteLine($"{_CurrentList[i].DisplayName()},{_CurrentList[i].DisplayDesc()},{_CurrentList[i].GetGoalPoints()},{_CurrentList[i].IsComplete()}");

                }else if (_CurrentList[i].GoalKind()==2)

                {
                    Goal actual = _CurrentList[i];
                    EternalGoal actualgoal = (EternalGoal)actual; 
                    outputFile.WriteLine($"{_CurrentList[i].DisplayName()},{_CurrentList[i].DisplayDesc()},{_CurrentList[i].GetGoalPoints()}");

                }else if (_CurrentList[i].GoalKind()==3)

                {
                    Goal actual = _CurrentList[i];
                    CheckListGoal actualgoal = (CheckListGoal)actual; 
                    outputFile.WriteLine($"{_CurrentList[i].DisplayName()},{_CurrentList[i].DisplayDesc()},{_CurrentList[i].GetGoalPoints()},{actualgoal.GetBonusPoints()},{actualgoal.GetAtualReps()},{actualgoal.GetRequiredReps()}");

                }
               


     
           
            }
        
        }
    }
    public List<Goal> LoadGoal(string filename)
    {
    
        string[] loadgoals = System.IO.File.ReadAllLines(filename);

            _CurrentList.Clear();
            foreach (string line in loadgoals)
            {
                string[] parts = line.Split(",");
                if (parts.Count()==1)
                {
                    _points = int.Parse(parts[0]);

                }else if (parts.Count()==4)
                {
                    SimpleGoal simplegoal = new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]));
                    if (parts[3]=="True")
                    {
                    simplegoal.RecordEvent();
                    }
                
                    _CurrentList.Add(simplegoal);
                
                
                }else if (parts.Count()==6)
                {
                    CheckListGoal checklistgoal = new CheckListGoal(parts[0], int.Parse(parts[2]), parts[1], int.Parse(parts[5]), int.Parse(parts[3]));
                    int i =0;
                    while(int.Parse(parts[4])>i){
                    checklistgoal.RecordEvent();
                    i++;

                }
                _CurrentList.Add(checklistgoal);

                }else if (parts.Count()==3)
                {
                    EternalGoal eternalgoal = new EternalGoal(parts[0],int.Parse(parts[2]), parts[1]);
                    _CurrentList.Add(eternalgoal);
                }
             
                
            }
        
        return _CurrentList;


    }




    

    public int GetSavedPoints(){
        
      return _points;
    }











} 