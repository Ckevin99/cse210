using System;

public class Reference
{
          private string _formated;
          private string _verse;
          private string _chapter;
          private string _book;
          private string _lastVerse;
          private bool _multipleVerse;

 
          public Reference(string[] reference)
          {
           
               _verse = reference[2];
               _chapter = reference[1];
               _book = reference[0];

               _multipleVerse = false;

              if (reference.Count()==4)
              {
                   _lastVerse = reference[3];
                   _multipleVerse = true;
              }
            
          }
        
        
          public string GetFormated()
          {
               if (_multipleVerse)
               {
                    _formated = $"{_book} {_chapter}:{_verse}-{_lastVerse}";
               } else if (!_multipleVerse)
               {
                    _formated = $"{_book} {_chapter}:{_verse}";
               }
                    return _formated;
          }
        
}