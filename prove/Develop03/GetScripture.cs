using System;

public class GetScripture
{

    private List<string> _scriptures = new List<string>();
    private List<string> _references = new List<string>();
    private int _randomnum;



    public void LoadsScriptures()
    {

        string[] loadscriptures = System.IO.File.ReadAllLines("scriptures.txt");
  
        foreach (string scripture in loadscriptures)
        {
            string[] parts = scripture.Split("–");
            _scriptures.Add(parts[1]);
            _references.Add(parts[0]);

        }
   }
public string SelectScripture()
{
    return _scriptures[_randomnum];

   
}

public string[] SelectReference()
{
     Random rand = new Random();

    _randomnum = rand.Next(0,6);

    string[] reference = _references[_randomnum].Trim().Replace(" ","-").Replace(":","-").Split("-");

    return reference;
    
}


}