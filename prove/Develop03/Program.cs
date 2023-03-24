using System;
using System.Collections.Generic;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
         string userinput;

        GetScripture getscripture = new GetScripture();

        getscripture.LoadsScriptures();

        string[] scripturereference = getscripture.SelectReference();
    
        Reference reference = new Reference(scripturereference);

        string scripreference = reference.GetFormated();

        Scripture scripture = new Scripture(getscripture.SelectScripture(), scripreference);

        
        do{
            scripture.Display();
            
            userinput = scripture.IsCompletely();
            scripture.Hide();

            Console.WriteLine("\n\nPress enter to continue or Type 'quit' to finish");
            if (userinput=="no"){
                userinput = Console.ReadLine();
                Console.Clear();
            }
 


            
            
        
        
      
        }while(userinput != "quit");
    }
    
}