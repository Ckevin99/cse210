using System;
using System.IO;

public class Journal{
    
    public List<string> _answers = new List<string>();    
       
    public void LoadJournal(List<string> answerslist, string filename)
    {     
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        foreach  (string line in lines)
        {
            answerslist.Add(line);
        }    

    }

    public void SaveJournal(List<string> answerslist, string filename)
    {
        using (StreamWriter File = new StreamWriter(filename))
        {
            foreach (string answer in answerslist)
            {
                File.WriteLine($"{answer}");
            }
        }
        
    

    }
    public void DisplayEntries(List<string> entries)
    {
        foreach (string entry in entries)
        {
            Console.WriteLine(entry);
        } 

    }

    

    
    
        
    }