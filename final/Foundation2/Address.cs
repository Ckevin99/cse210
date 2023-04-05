using System;




class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country){

        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;

    } 


    public bool IsInUSA(){
        if (_country.ToUpper() == "USA"|| _country.ToUpper() == "UNITED STATES"){

            return true;
        }

        return false;



    }


    public string FullAddress(){
        string fullAdress = $"Street Address : {_streetAddress}\nCity : {_city}\nState : {_state}\nCountry : {_country}";

        return fullAdress;
    }















}