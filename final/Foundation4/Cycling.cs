using System;



class Cycling : Activity {
    private double _speed;
    private string _activityType;



    public Cycling(double speed, string date, double length) : base(date , length)
    {

       _speed = speed;
       _date = date;
       _length = length;
       _activityType = "Cycling";

    }

    protected override double CalculateDistance(){

        double distance = _speed*(_length/60);
        return distance;
    }

    protected override double CalculateSpeed(){

        return _speed;
    }

    protected override double CalculatePace(){

        return 60/_speed;
    }

    public override void DisplaySummary(){
  
        Console.WriteLine($"{_date} {_activityType} ({_length} min) - Distance {Math.Round(CalculateDistance(),2)} km, Speed {Math.Round(CalculateSpeed(),2)} Kph, Pace: {Math.Round(CalculatePace(),2)} min per Kilometer ");

    }











}