public class Scripture
{
    private List<string> _words = new List<string>();
    private List<Word> _wordsObject = new List<Word>();
    private List<int> _hided = new List<int>();
    private string references;
     

    public void Display()
    {
        Console.Write($"{references} ");
        foreach(Word x in _wordsObject)
        {
            Console.Write(x.GetWord()+" ");
        }
    }
     
    public Scripture(string scripture, string reference)
    {
        List<string> _words = scripture.Split(' ').ToList();
        references = reference;

        foreach (string x in _words)
        {
            Word word = new Word(x);
            _wordsObject.Add(word);
        }
 
         
    }

    public string IsCompletely()
    {
       foreach (Word x in _wordsObject)
       {
            if (!x.IsHided())
            {
                return "no";
            }
       }
        return "quit";

    }




    public void Hide()
    {
        Random rand = new Random();
        int erased;
        int times = 0;
        bool finish = false;
        do
        {
            finish = false;
        
            do
            {

                erased  = rand.Next(0, _wordsObject.Count);
                if (_hided.Count > _wordsObject.Count-1)
                {
                    finish= true;
   
                }
                else if(!_hided.Contains(erased))
                {
                    finish=true;
      
                }
                else if(_hided.Contains(erased))
                {
                    finish= false;

                }
            }while(!finish);

            _hided.Add(erased);
            _wordsObject[erased].Hide();
            times++;
        }while(3>times);
        
        
    }
        
}