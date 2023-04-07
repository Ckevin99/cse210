using System;





class Event{
    protected string _title;
    protected string _description;
    protected string _date;
    protected int _time;
    protected Address _address;
    protected string _eventKind;

    public Event(string title, string description, string date, int time, Address address){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        
    }

    public string DefaultMessage(){

        return $"{_title}\n{_description}\n{_date}\n{_address.GetAddress()}";

    }

    public string ShortMessage(){

        return $"{_eventKind}\n{_title}\n{_date}";

    }










}