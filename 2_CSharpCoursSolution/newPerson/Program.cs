using newPerson;
using System.Net.WebSockets;
//Концепция наследования и полиморфизма.
//Они нужны для того чтобы не писать один и тот же код дважды.
//Создаем базовый класс Shape, который будет содержать общие методы для всех фигур.
//Затем создаем классы Triangle и Rectangle, которые наследуются от Shape
//и реализуют свои методы Draw,Area и Perimeter.
{
    Shape[] shapes = new Shape[2];
    shapes[0] = new Triangle(10, 20, 30);
    shapes[1] = new Rectangle(10, 20);

    foreach (Shape shape in shapes)
    {
        shape.Draw();
        Console.WriteLine(shape.Perimeter());
    }
}
static void ModelXterminal(string[] args)
{
    ModelXTerminal terminal = new ModelXTerminal("123");
    terminal.connect();
    Console.ReadLine();
}
static void Pers(string[] args)
{ 
    var tom = new Person("Tom", 38);
    Console.WriteLine(tom);
}