using System;


class Program{

static void Main(string[] args){

    Square square = new Square("blue",3);
    

    Circle circle = new Circle(3,"red");


    Rectangle rectangle = new Rectangle(3,5,"yellow");


    List<Shape> shapes = new List<Shape>();
    shapes.Add(square);
    shapes.Add(circle);
    shapes.Add(rectangle);

    foreach (Shape x in shapes){
        Console.WriteLine(x.GetArea());
        x.GetColor();
        
    }




}
}
