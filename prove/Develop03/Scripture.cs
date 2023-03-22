 public class Scripture{
     private string _scripture;
     private List<string> _words = new List<string>();
     private List<int> _hided = new List<int>();
     
     public void SeparetedText() {
         _words = _scripture.Split(' ').ToList();

         
     }
    public void Display(){
        foreach(string x in _words){
             Console.Write(x+" ");
         }
    }
     
     public void SetText() {
         _scripture = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
         
     }
    public void Hide(){
        Random rand = new Random();
        int erased;
        bool finish = false;
        do{
            erased  = rand.Next(0, _words.Count);
            if (_hided.Count > _words.Count-1){
                finish= true;
                Console.WriteLine("1");
            }
             else if(!_hided.Contains(erased))
            {
                finish=true;
                Console.WriteLine("2");
            }
            else if(_hided.Contains(erased)){
                finish= false;
                Console.WriteLine("3");

            }
        }while(!finish);
        _hided.Add(erased);
        
        char[] charWord = _words[erased].ToCharArray();

        for (int i = 0; i < charWord.Length; i++) {
            charWord[i] = '_';
      }
      _words[erased] = new string (charWord);
   
        
        
     }
        
    }