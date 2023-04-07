using System;



class Swimming : Activity {
    private double _laps;
    private string _activityType;


    public Swimming(double laps, string date, double length) : base(date, length)
    {
        _laps = laps;
        _date = date;
        _length = length;
        _activityType = "Swimming";
        
    }


    protected override double CalculateDistance(){

      double distance = ((_laps*50)/1000);
      return distance;
    }

    protected override double CalculateSpeed(){

        return (CalculateDistance()/_length)*60;
    }

     protected override double CalculatePace(){

       return 60/CalculateSpeed();
    }

    public override void DisplaySummary(){
  
        Console.WriteLine($"{_date} {_activityType} ({_length} min) - Distance {Math.Round(CalculateDistance(),2)} km, Speed {Math.Round(CalculateSpeed(),2)} Kph, Pace: {Math.Round(CalculatePace(),2)} min per Kilometer ");

    }











}