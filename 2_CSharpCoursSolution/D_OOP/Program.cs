using Microsoft.VisualBasic;
using System;
using System.IO.Pipes;
using System.Threading.Channels;


namespace D_OOP
{
    public class Program
    {
        

        static void Main(string[] args)
        {    
            Person vasea = new Person("Vasyli", 25);
            Console.WriteLine(vasea);

            //Конструктор - призванны защищать начальное состояние объекта, инициализировать его поля и свойства.
            {
                Character c = new Character("Elf");
                Console.WriteLine(c.Race);
            }
            static void Average2(string[] args)
            {
                double result = Calculator.Average2(1, 2, 3);
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
        }
<<<<<<< Updated upstream
     }
}     
=======
    }
}     
>>>>>>> Stashed changes
