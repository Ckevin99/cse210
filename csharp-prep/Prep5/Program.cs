using System;

class Program
{
   static void DisplayWelcome(){
    Console.WriteLine("Welcome to the Program!");
    
}

static string PromptUserName(){
    Console.WriteLine("What is your name?");
    return Console.ReadLine();
}

static int PromptUserNumber() {
    Console.WriteLine("What is your favorite Number?");
    return int.Parse(Console.ReadLine());
}
static int SquareNumber( int a){
    return a*a;
}
static void DisplayResult(string name, int number){
    Console.WriteLine($"Your name is: {name}");
    Console.WriteLine($"Your favorite number is: {number}");
}


    
static void Main(string[] args) {
    
DisplayWelcome();
string name = PromptUserName();
int favnum = PromptUserNumber();
int squarenum = SquareNumber(3);
DisplayResult(name, favnum);
}
}