using System;
using System.IO;




public class SaveLoad{
    List<Goal> _CurrentList = new List<Goal>(); 
    string _filename;


    public SaveLoad(List<Goal> list, string filename){
        _CurrentList = list;
        _filename = filename;
    }

    public SaveGoal(){
        using (streamWriter outputFile = new streamWriter(filename))

        foreach (Goal x in _CurrentList){

            outputFileWriteLine("")

        }
        


    }
    public LoadGoal(){


    }










} 