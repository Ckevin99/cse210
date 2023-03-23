using System;

public class GetScripture{

private List<string> _scriptures = new List<string>();
private List<string> _references = new List<string>();
private int randomnum;


public void LoadsScriptures(){

   string[] loadscriptures = System.IO.File.ReadAllLines("scriptures.txt");
  
   foreach (string scripture in loadscriptures){
    string[] parts = scripture.Split("-");
    _scriptures.Add(parts[1]);
    _references.Add(parts[0]);

   }
   }
public string SelectScripture(){
    Random rand = new Random();
    randomnum = rand.Next(0,2);
    return _scriptures[randomnum];
}
public string[] SelectReference(){
    string[] reference = _references[randomnum].Replace(" ","-").Replace(":","-").Split("-");
    return reference;
    
}


}