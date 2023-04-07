using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> list = new List<Activity>();
        Cycling cycling = new Cycling(12,"05 May 2023", 42);
        list.Add(cycling);
        Running running = new Running(10,"25 Nov 2022", 60);
        list.Add(running);
        Swimming swimming = new Swimming(15,"30 Jan 2023", 15);
        list.Add(swimming);



        foreach (Activity x in list){
            x.DisplaySummary();
        
        }


                                      

    
}
}