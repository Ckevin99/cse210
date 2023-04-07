using System;



abstract class Activity{
    protected string _date;
    protected double _length;
 


    public Activity(string date, double length){
        _date = date;
        _length = length;

    }


    protected abstract double CalculateDistance();

    protected abstract double CalculateSpeed();

    protected abstract double CalculatePace();

    public abstract void DisplaySummary();







}