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

        break;
        case "2":

        break;
        case "3":

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
