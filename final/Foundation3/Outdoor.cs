using System;



class Outdoor : Event{
    private string _weather;


    public Outdoor(string weather, string title, string description, string date, int time, Address address):base(title, description, date, time, address){
        _weather = weather;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventKind ="Outdoor";


    }


    
    public string FullMessage(){

    return $"{_eventKind}{_title}\n{_weather}\n{_description}\n{_date}\n{_address.GetAddress()}";


    }














    
}