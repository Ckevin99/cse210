using System;


public class MathAssignment : Assignment{

    private string _textBookSection;
    private string _Problems;

    public MathAssignment(string studentName,string topic, string textBookSection, string Problems):base(topic, studentName) {
        
        _textBookSection = textBookSection;
        _Problems = Problems;

    }


    public string GetHomeworkList(){

        return $"{_textBookSection} {_Problems}";
    }








}