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
        Reference reference = new Reference(scripturereference[0],scripturereference[1],scripturereference[2]);
        string scripreference = reference.GetFormated();

        Scripture scripture = new Scripture(getscripture.SelectScripture(), scripreference);

        
        
        do{
            scripture.Display();
            scripture.Hide();
            userinput = scripture.IsCompletely();
            if (userinput=="no"){
                userinput = Console.ReadLine();
            }
 


            
            
        
        
      
        }while(userinput != "quit");
    }
    
}