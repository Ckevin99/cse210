using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("Please, type Your Grade!");
        int grade = int.Parse(Console.ReadLine());

        if (grade>=90){
            Console.WriteLine("A grade");
            Console.WriteLine("Congrats! you passed!");
        }else if(grade>=80 && grade<90){
            Console.WriteLine("B grade");
            Console.WriteLine("Congrats! you passed!");
        }else if(grade>=70 && grade<80){
            Console.WriteLine("C grade");
            Console.WriteLine("Congrats! you passed!");
        }else if(grade>=60 && grade<70){
            Console.WriteLine("D grade");
            Console.WriteLine("Congrats! you passed!");
            
        }else{
            Console.WriteLine("F grade");
            Console.WriteLine("You failed, but you can try again!")

        }

    }
}