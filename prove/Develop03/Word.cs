using System;

public class Word {
      private string _word;
      private string _wordHided;
      private bool _isHide;
        
        public Word(string x){
            
            _word = x;
            _isHide = false;
        }

        public void Hide(){

            char[] charWord = _word.ToCharArray();
            _isHide = true;

            for (int i = 0; i < charWord.Length; i++) {
                charWord[i] = '_';
      }
            _wordHided = new string (charWord);
          

        }
        public string GetWord(){
            if (_isHide){
                return _wordHided;
            }else{
                return _word;
            }
        }
        public bool IsHided(){
           return _isHide;
        }
        
    }