using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        job kevin = new job();
        kevin._company = "IBGE";
        kevin._jobTitle = "ACAI";
        kevin._startYear = "2022";
        kevin._endYear = "2023";
        kevin.Display();
        job another = new job();
        another._company = "FS";
        another._jobTitle = "Tec informatica";
        another._startYear = "2017";
        another._endYear = "2017";
        resume myResume = new resume();
        myResume._name = "Kevin";
        myResume._jobs.Add(kevin);
        myResume._jobs.Add(another);
        myResume.Display();


        
    }
        
    }

