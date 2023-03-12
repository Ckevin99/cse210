using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    
    public void GeneratePrompt()
    {
            Random num = new Random();
            int prompt = num.Next(0,4);
            Console.WriteLine(_prompts[prompt]);
    }
    
    public void LoadPrompts(List<string> addPrompts)
    {
        string[] loadPrompts = System.IO.File.ReadAllLines("prompts.txt");
        foreach( string loadPrompt in loadPrompts)
        {
             addPrompts.Add(loadPrompt);    
        }


        
    }  
    
}