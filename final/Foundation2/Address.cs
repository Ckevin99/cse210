using System;




class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;


    public bool IsInUSA(){
        if (_country.ToUpper() == "USA"||_country.ToUpper() == "United States"){

            return true;
        }

        return false;



    }


    public string FullAddress(){
        fullAdress = $"Street Address : {_streetAddress}\nCity : {_city}\nState : {_state}Country : {_country}";

        return fullAdress;
    }















}