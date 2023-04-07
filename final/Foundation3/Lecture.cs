using System;




class Lecture : Event{
    private string _speaker;
    private int _capacity;


    public Lecture(string speaker, int capacity, string title, string description, string date, int time, Address address):base(title, description, date, time, address){
        _speaker = speaker;
        _capacity = capacity;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventKind= "Lecture";


    }



    public string FullMessage(){


        return $"{_eventKind}{_title}\n{_speaker}\n{_capacity}{_description}\n{_date}\n{_address.GetAddress()}";
    }

   



}