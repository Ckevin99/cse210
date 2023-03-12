using System;

public class Entry
{
    public string _date;
    public string _answer;
 
    
    public string GetEntry(){
        _answer = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        return $"{_date}: {_answer}";
    }

}