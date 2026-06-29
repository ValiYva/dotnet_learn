using System;


namespace D_OOP
{
    class program
    {
        static void Main(string[] args) 
        {
            {
                Calculator calc = new Calculator();
                double square1 = calc.CalcTriangleSquare( 10, 20);
                double square2 = calc.CalcTriangleSquare(40, 10, 30);
                Console.WriteLine($"Square1={square1}. Square2={square2}");
            }
        static void Character(string[] args)
        {
            Character c = new Character();
            c.Hit(130);
            Console.WriteLine(c.Health);
        }

    }    }
}