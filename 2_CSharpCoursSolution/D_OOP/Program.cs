using System;


namespace D_OOP
{
    class program
    {
        static void Main(string[] args)
        {
            static void Average2(string[] args)
            {
                double result = Calculator.Average2 (1, 2, 3 );
                Console.WriteLine(result);
            }
                    
            static void Parse(string[] args)
            {

                Console.WriteLine("Enter a number please.");
                
                
               

            }
            static void Average(string[] args)
            {
                
                double avg = Calculator.Average2(1, 2, 3, 4);
                Console.WriteLine(avg);
            }
            static void Calculato(string[] args)
            {
               
                double square1 = Calculator.CalcTriangleSquare(10, 20);
                double square2 = Calculator.CalcTriangleSquare(40, 10, 30);
                Console.WriteLine($"Square1={square1}. Square2={square2}");
            }
            static void Character(string[] args)
            {
                Character c = new Character();
                c.Hit(130);
                Console.WriteLine(c.Health);
            }




        }
     }
}     
