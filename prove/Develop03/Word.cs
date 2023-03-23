using System;

public class Word {
      private string _word;
      private string _wordhided;
      private bool _ishide;
        
        public Word(string x){
            
            _word = x;
            _ishide = false;
        }

        public void hide(){

            char[] charWord = _word.ToCharArray();
            _ishide = true;

            for (int i = 0; i < charWord.Length; i++) {
                charWord[i] = '_';
      }
            _wordhided = new string (charWord);
          

        }
        public string GetWord(){
            if (_ishide){
                return _wordhided;
            }else{
                return _word;
            }
        }
        public bool ishided(){
           return _ishide;
        }
        
    }