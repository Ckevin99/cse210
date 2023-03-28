using System;



class Program
{
    static void Main(string[] args)
    {
        string userinput;
        do{
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity\n2. Start Reflecting Activity\n3. Start listing Activity\n4. Quit");
            Console.WriteLine("Select a choice from the menu:");
            userinput = Console.ReadLine();

        switch(userinput){

        case "1": 
            BreathingActivity breathingactivity = new BreathingActivity();
            breathingactivity.DisplayStartMessage();
            breathingactivity.TimeSession();
            breathingactivity.Breathing();


        break;
        case "2":
            ReflectionActivity reflectionactivity = new ReflectionActivity();
            reflectionactivity.DisplayStartMessage();
            reflectionactivity.TimeSession();
            reflectionactivity.Reflection();
        break;
        case "3":
        ListingActivity listingactivity = new ListingActivity();
        listingactivity.DisplayStartMessage();
        listingactivity.TimeSession();
        listingactivity.Listing();

        break;

        case "4":
        break;

        default:
            Console.WriteLine("\nPlease, Type a number in the menu\n");

        break;


        }

        }while(userinput!="4");
       
    }
    
}
