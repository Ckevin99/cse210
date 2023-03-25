using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    Assignment assignment = new Assignment("kevin","Multiplication");
    Console.WriteLine(assignment.GetSummary());

    MathAssignment mathassigment = new MathAssignment("Kevin", "Fraction","Section 7.3","Problem 8-19");
    Console.WriteLine(mathassigment.GetSummary());
    Console.WriteLine(mathassigment.GetHomeworkList());

    WritingAssignments writingassignment = new WritingAssignments("Kevin", "European History","The Causes of World War II");
    Console.WriteLine(writingassignment.GetSummary());
    Console.WriteLine(writingassignment.GetWritingInformation());
    }
}