using System;



class Running : Activity {
    private double _distance;
    private string _activityType;


    public Running(double distance, string date, double length) : base(date,length)
    {
        _distance = distance;
        _date = date;
        _length = length;
        _activityType= "Running";

    }


    protected override double CalculateDistance(){

      return _distance;
    }

    protected override double CalculateSpeed(){


        return (_distance/_length)*60;
    }

    protected override double CalculatePace(){

       return 60/CalculateSpeed();
    }

    public override void DisplaySummary(){
  
        Console.WriteLine($"{_date} {_activityType} ({_length} min) - Distance {Math.Round(CalculateDistance(),2)} km, Speed {Math.Round(CalculateSpeed(),2)} Kph, Pace: {Math.Round(CalculatePace(),2)} min per Kilometer ");

    }








}