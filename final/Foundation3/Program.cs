using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Street B","rexburg","idaho","EUA");
        Address address2 = new Address("1731 Heavner Avenue","Duluth","Georgia","EUA");
        Address address3 = new Address("2386 Denver Avenue","Mira","California","EUA");



        Lecture lecture = new Lecture("Kevin Correia", 500, "A title here", "we will have a lecture talking about this","25/5/2023",60, address1);
        Outdoor outdoor =  new Outdoor("Open cloud", "soccer tournement", "a football soccer tournenament", "25/5/2023", 180, address2);
        Receptions receptions = new Receptions("receptions@gmail.com", "A event", "A event which will...", "30/10/2023", 120, address3);

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