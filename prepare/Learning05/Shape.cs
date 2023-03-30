using System;



public class Shape{
       
       protected string _color;






    public Shape(string color){
        _color = color;
      
    }
    public void GetColor(){
        Console.WriteLine(_color);
    }


    public virtual double GetArea(){

    return 1;


    }













}