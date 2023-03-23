using System;

public class Reference{
        private string _formated;
        private string _verse;
        private string _chapter;
        private string _book;
        private string _lastverse;

        public Reference(string book, string chapter, string verse){

             _verse = verse;
             _chapter = chapter;
             _book = book;
     
            
            
        }
        public Reference(string book, string chapter, string verse, string lastverse){
           
             _verse = verse;
             _chapter = chapter;
             _book = book;
             _lastverse = lastverse;
            
            
        }
        
        
        public string GetFormated(){

            _formated = $"{_book} {_chapter}:{_verse}";
            
            return _formated;
        }
        
    }