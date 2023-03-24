using System;
using System.Collections.Generic;
using System.Linq;

// Exceeds core requirements.
//*Have your program work with a library of scriptures rather than a single one. Choose scriptures at random to present to the user.
//*Have the program to load scriptures from files.

// My Program have a GetScripture Class, It will load a file with a list of different scriptures(single and multiple verses) and select randomly one.
// Strect Challenge - My Program will hide only Words that were not hidden yet.



public class HelloWorld
{
    public static void Main(string[] args)
    {
         string userinput;

        GetScripture getscripture = new GetScripture("scriptures.txt");

        getscripture.LoadsScriptures();

        string[] scripturereference = getscripture.SelectReference();
    
        Reference reference = new Reference(scripturereference);

        Scripture scripture = new Scripture(getscripture.SelectScripture(), reference.GetFormated());

        
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