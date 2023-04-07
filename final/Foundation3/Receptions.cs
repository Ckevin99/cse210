using System;



class Receptions : Event{
    private string _email;


    public Receptions(string email, string title, string description, string date, int time, Address address):base(title, description, date, time, address){
        _email = email;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventKind = "Receptions";

    }


   
    public string FullMessage(){

    return $"{_eventKind}\n{_title}\n{_email}\n{_description}\n{_date}\n{_address.GetAddress()}";

    }


}