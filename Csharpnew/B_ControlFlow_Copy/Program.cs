using System;

namespace B_ControlFlow
{
    class Program
    {
       
        static void Main(string[] args)
        {
           
          int weddingYears = int.Parse(Console.ReadLine());

            string name = string.Empty;

            switch (weddingYears)
            {
                case 5:
                    name = "Деревянная свадьба";
                    break;
                case 10:
                    name = "HAppe";
                    break;
                case 15:
                    name = "Хрустальная свадьба";
                    break;
                case 20:
                    name = "Фарфоровая свадьба";
                    break;
                case 25:
                    name = "Серебрянная свадьба";
                    break;
                case 30:
                    name = "Жемчужная свадьба";
                    break;

                    default:
                    name = "Не знаем такого юбилея";
                    break;

                   

            }

            Console.WriteLine(name);


          static void AgeCheck(string[] args)
        {
            int age = 0;
            while (age < 18)
            {
                Console.WriteLine($"What's your age?");
                age = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Good");
        }


         static void CompareNumbersHW(string[] args)      
        {
            Console.WriteLine($" First Player, put your number");
            int firstPlayerNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($" Second Player, put your number");
            int secondPlayerNumber = int.Parse(Console.ReadLine());

            string description = firstPlayerNumber > secondPlayerNumber ? "First player have maximum" : "Second player have maximum";

            Console.WriteLine(description);




        }

        static void BMI (string[] args)
        {

            Console.WriteLine($"What's yor age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"What's yor weight in kg?");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine($"What's your height in cm ?");
            double height = double.Parse(Console.ReadLine());

            double bmi = weight / (height * height);


            bool isTooLow = bmi < 18.5;

            bool isNormal = bmi >= 18.5 && bmi < 25;

            bool isAboveNormal = bmi >= 25 && bmi < 30;

            bool isTooFat = bmi >= 30;

            bool isFat = isAboveNormal || isTooFat;

            if (isFat)
            {
                Console.WriteLine("You'd better lose some weight");

            }
            else
            {
                Console.WriteLine("You are in good shape");
            }

            //if(isFat == false)
            if (!isFat)
            {
                Console.WriteLine("You're definitely not fat!");
            }
            if (isTooLow)
            {
                Console.WriteLine("Not enough weight.");
            }
            else if (isNormal)
            {
                Console.WriteLine("You're ok");
            }
            else if (isAboveNormal)
            {
                Console.WriteLine("Be careful");
            }
            else
            {
                Console.WriteLine("You need to lose same weight.");
            }
            if (isFat || isTooFat )
            {
                Console.WriteLine("Anyway, you need to lose some weight.");
            }

            //Ternary operator
            string description = age > 18 ? "You can drink alcohol" : "Child";


            //The same with if else construcktion
            //if (age > 18)
            //{
                //description = "You can drink alcohol";
            //}
            //else
            //{
               // description = "Child";
            //}
            Console.WriteLine(description);

        }  

     }
 
}
}