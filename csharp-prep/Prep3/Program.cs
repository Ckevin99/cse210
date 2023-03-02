using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
          bool bypass = false;
      Random randomNum = new Random();
      int secNum = randomNum.Next(1,101);
     
      do{
      Console.WriteLine("Please, Type a number");
      int userNum = int.Parse(Console.ReadLine());
        if (secNum == userNum){
            bypass = true;
            Console.WriteLine("Congrats!");
        } else if(secNum < userNum){
            Console.WriteLine("Lower");
        } else if (secNum > userNum){
            Console.WriteLine("Greater");
        }
          
      }while(bypass == false);
    }
}