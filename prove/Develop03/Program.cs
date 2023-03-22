using System;
using System.Collections.Generic;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string userinput;
        Scripture scripture = new Scripture();
        scripture.SetText();
        scripture.SeparetedText();
        do{
        scripture.Display();
        userinput = Console.ReadLine();
        scripture.Hide();
        Console.Clear();
        
        
      
        }while(userinput != "quit");
    }
    
    
    public class ScriptureGenerate {
        // private  _scriptures store in a list
        
         //_private loadfile ( load a list of scriptures)
         
         //_public string  GeneateScripture (get a scripture from the list)
    }
}