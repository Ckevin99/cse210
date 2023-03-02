using System;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Enter numers to the List, type 0 to finisih.");
    List<int> numeros = new List<int>();
    int uinput;
    do{
        uinput = int.Parse(Console.ReadLine());
        if (uinput != 0){
            numeros.Add(uinput);
        }
        
    }while(uinput != 0);
    int totalamount = 0;
    int greatest = 0;
    int smallest = 10000000;
    foreach (int x in numeros){
        totalamount += x;
    }
    foreach(int x in numeros){
        if (greatest<x){
            greatest = x;
        }
    }
    foreach(int x in numeros){
        if (x>0){
            if (smallest>x){
                smallest =x;
            }
        }
    }
    numeros.Sort();
    int average = totalamount/numeros.Count;
    foreach (int x in numeros){
        Console.WriteLine(x);
    }
    Console.WriteLine($"The smallest positive is: {smallest}");
    Console.WriteLine($"The average is: {average}");
    Console.WriteLine($"Total is {totalamount}");
    Console.WriteLine($"The greatest number is: {greatest}");
    
    
    }
}