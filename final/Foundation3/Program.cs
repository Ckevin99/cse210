using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("212 Street B","rexburg","idaho","EUA");
        Address address2 = new Address("1731 Heavner Avenue","Duluth","Georgia","EUA");
        Address address3 = new Address("2386 Denver Avenue","Mira","California","EUA");


        
        Lecture lecture = new Lecture("Heitor Santos", 100, "Business Conference", "we will have a lecture with companies owners talking about how to overcome specific challenges.","25/5/2023",70, address1);
        Outdoor outdoor =  new Outdoor("Open Sky", "Running", "A running to everyone! it running will be of 6 kilometers", "25/5/2023", 180, address2);
        Receptions receptions = new Receptions("receptions@gmail.com", "Wedding", "The weeding of marta and joão ", "30/10/2023", 150, address3);

        Console.WriteLine(lecture.ShortMessage());
        Console.WriteLine("");
        Console.WriteLine(lecture.DefaultMessage());
        Console.WriteLine("");
        Console.WriteLine(lecture.FullMessage());
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine(outdoor.ShortMessage());
        Console.WriteLine("");
        Console.WriteLine(outdoor.DefaultMessage());
        Console.WriteLine("");
        Console.WriteLine(outdoor.FullMessage());
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine(receptions.ShortMessage());
        Console.WriteLine("");
        Console.WriteLine(receptions.DefaultMessage());
        Console.WriteLine("");
        Console.WriteLine(receptions.FullMessage());
    }
}