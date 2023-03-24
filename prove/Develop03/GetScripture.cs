using System;

public class GetScripture
{

    private List<string> _scriptures = new List<string>();
    private List<string> _references = new List<string>();
    private int _randomNum;
    private string fileName;

    
    public GetScripture(String file){
    fileName = file;

    }



    public void LoadsScriptures()
    {

        string[] loadscriptures = System.IO.File.ReadAllLines(fileName);
  
        foreach (string scripture in loadscriptures)
        {
            string[] parts = scripture.Split("–");
            _scriptures.Add(parts[1]);
            _references.Add(parts[0]);

        }
   }
public string SelectScripture()
{
    return _scriptures[_randomNum];

   
}

public string[] SelectReference()
{
     Random rand = new Random();

    _randomNum = rand.Next(0,6);

    string[] reference = _references[_randomNum].Trim().Replace(" ","-").Replace(":","-").Split("-");

    return reference;
    
}


}