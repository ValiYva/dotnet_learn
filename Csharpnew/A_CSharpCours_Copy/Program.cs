using D_OOP;
using System;
using System.Formats.Asn1;
using System.Text;
using System.Xml;

namespace CSharpCours
{
    class Program
    {
        static void Main(string[] args)
        {
            {
              Character c = new Character();
               c.Hit (10);
            }
            static void Homework4()
            {
                Console.WriteLine($"What's yor name");
                string name = Console.ReadLine();

                Console.WriteLine($"What's yor Surname");
                string surname = Console.ReadLine();

                Console.WriteLine($"What's yor age");
                string age = Console.ReadLine();

                Console.WriteLine($"What's yor weight in kg?");
                double weight = Convert.ToDouble( Console.ReadLine());

                Console.WriteLine($"What's your height in cm ?");
                double height = Convert.ToDouble(Console.ReadLine());

                double bmi = weight / (height * height);

                Console.WriteLine($"\nYour profile: \nYoure name:{name} \nFull name:{surname} \nAge:{age}  \nYour Body Mass Index:{bmi:F1}  ");




            }

            static void Homework3()
            {
                Console.WriteLine($" Enter the third side of the triangle A ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($" Enter the third side of the triangle B ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($" Enter the third side of the triangle C ");
                double c = Convert.ToDouble(Console.ReadLine());

                double p = (a + b + c) / 2.0;

                double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                Console.WriteLine($"Third of triangle (S) = {area:F2}");


         
            }

            static void Homework2()
            {
                //Homework #2
                Console.WriteLine($"Enter an integer ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter an integer ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine($"a={a}, b={b}");

                int c = a;
                a = b;
                b = c;
                Console.WriteLine($"a={a}, b={b}");
            }

            static void Homework1()
            {
               //Homework #1 

               Console.WriteLine($"WHat is yor name?");

               string name = Console.ReadLine();

               Console.WriteLine($"Hello {name}, nice to meet you! ");
            }

            static void DateTimeExample()
            {
                DateTime now = DateTime.Now;
                Console.WriteLine(now.ToString());

                Console.WriteLine($"It's {now.Date}, {now.Hour}:{now.Minute}");

                DateTime dt = new DateTime(2019, 02, 21);
                DateTime newDt = dt.AddDays(1);
                Console.WriteLine(newDt);
                TimeSpan ts = newDt - dt;
                Console.WriteLine(ts.Days);
            }

            static void ArrayExample()
                {
                    int[] a1;
                a1 = new int[10];
                int[] a2 = new int[5];
                int[] a3 = new int[5] { 1, 2, 4, 5, 6 };
                int[] a4 = { 1, 2, 4, 5, 6 };
                Console.WriteLine(a4[0]);
                int number = a4[4];
                Console.WriteLine(number);

                a4[4] = 6;
                Console.WriteLine(a4[4]);

                Console.WriteLine(a4.Length);
                Console.WriteLine(a4[a4.Length - 1]);
                string s1 = " FWFWEFWEF WEF";
                char first = s1[0];
                char last = s1[s1.Length - 1];
                Console.WriteLine($"First:{first}. Last:{last}");

            }

            static void StringInterpolation()
            {
                string name = "Vali";
                int age = 28;
                string str1 = string.Format("My name is {0} and I'm {1}", name, age);
                string str2 = $"My name is {name} and I'm {age}";
                //string str2 = $"My name is" + name + " and I'm " + age;
                string str3 = $"My name is {name} \n and I'm {age - 1}";
                string str4 = "I'm \t30";
                string str5 = "My name is Vali and I'm \"good\" programmer";
                string str6 = @"C:\Users\Vali\Documents\CSharpCours";

                int answer = 42;
                string result = string.Format("The answer is {0:4}", answer);
                string result2 = string.Format("The answer is {0:d4}", answer);

                result = string.Format("The answer is {0:f}", answer);
                result2 = string.Format("The answer is {0:f4}", answer);


                Console.WriteLine(result);
                Console.WriteLine(result2);

                double answer1 = 42.3;
                //string result = string.Format("The answer is {0:4}", answer);
                //string result2 = string.Format("The answer is {0:d4}", answer);

                string result11 = string.Format("The answer is {0:f}", answer1);
                string result22 = string.Format("The answer is {0:f4}", answer1);


                Console.WriteLine(result);
                Console.WriteLine(result2);

            }

            static void StringBuilderExample()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("My ");
                sb.Append("name ");
                sb.Append("is ");
                sb.Append("John");
                sb.AppendLine("!");
                sb.AppendLine("I am a softsware developer.");

                string str = sb.ToString();
                Console.WriteLine(str);

            }

            static void stringexemple()
            {
                string nameConcat = string.Concat("my ", "name ", "is ", "John ");
                string nameJoin = string.Join(" ", "my", "name", "is", "John");
                Console.WriteLine(nameConcat);
                Console.WriteLine(nameJoin);

                //string newName = 
                nameConcat = nameConcat.Insert(0, "By the way, ");
                Console.WriteLine(nameConcat);

                nameConcat = nameConcat.Remove(0, 1);
                Console.WriteLine(nameConcat);

                string replaced = nameConcat.Replace("n", "z");
                Console.WriteLine(replaced);

                string data = " 12;28;34;25;64; ";
                string[] splindata = data.Split(';');
                string first = splindata[0];
                Console.WriteLine(first);
                char[] chars = nameConcat.ToCharArray();

                string lower = nameConcat.ToLower();
                Console.WriteLine(lower);
                string apper = nameConcat.ToUpper();
                Console.WriteLine(apper);

                string john = "My name is John";
                Console.WriteLine(john.Trim());

            }

            static void StringEmptyness()
            {
                string str = String.Empty;  //same as ""
                string empty = "";
                string whiteSpaced = " ";
                string notEmpty = "b";
                string nullString = null;

                Console.WriteLine("IsNullOrEmpty");
                bool IsNullOrEmpty = string.IsNullOrEmpty(nullString);
                Console.WriteLine(IsNullOrEmpty);

                IsNullOrEmpty = string.IsNullOrEmpty(whiteSpaced);
                Console.WriteLine(IsNullOrEmpty);

                IsNullOrEmpty = string.IsNullOrEmpty(notEmpty);
                Console.WriteLine(IsNullOrEmpty);

                IsNullOrEmpty = string.IsNullOrEmpty(empty);
                Console.WriteLine(IsNullOrEmpty);

                Console.WriteLine();
                Console.WriteLine("IsNullOrWhiteSpace");

                bool IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(nullString);
                Console.WriteLine(IsNullOrWhiteSpace);

                IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(whiteSpaced);
                Console.WriteLine(IsNullOrWhiteSpace);

                IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(notEmpty);
                Console.WriteLine(IsNullOrWhiteSpace);

                IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(empty);
                Console.WriteLine(IsNullOrWhiteSpace);

            }

            static void StringMethods2()
            {


                string name = "abracadabra";
                bool containsA = name.Contains('a');
                bool containsE = name.Contains("e");

                Console.WriteLine(containsE);
                Console.WriteLine(containsA);

                bool endWithAbra = name.EndsWith("ebra");
                Console.WriteLine(endWithAbra);

                bool startWithAbra = name.StartsWith("abra");
                Console.WriteLine(startWithAbra);

                int indexOfA = name.IndexOf('a', 1);
                Console.WriteLine(indexOfA);

                int lastIndexOfR = name.LastIndexOf('r');
                Console.WriteLine(lastIndexOfR);

                Console.WriteLine(name.Length);
                string substrFrom5 = name.Substring(5);
                string substrFromTo = name.Substring(0, 3);
                Console.WriteLine(substrFromTo);
                Console.WriteLine(substrFrom5);





            }

            static void Main(string[] args)
            {

                int x = 0b11;
                int y = 0b1001;
                int k = 0b10001001;
                int m = 0b1000_1001;

                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine(k);
                Console.WriteLine(m);

                x = 0x1F;
                y = 0xFF0D;
                k = 0x1FAB30EF;
                m = 0x1FAB_30EF;

                Console.WriteLine();
                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine(k);
                Console.WriteLine(m);
                Console.ReadLine();
            }

            static void StringMethods()
            {
                string name = "Abracadabra";
                bool containsA = name.Contains('a');
                bool containsE = name.Contains("e");

                Console.WriteLine(containsE);
                Console.WriteLine(containsA);

                string abc = string.Concat("a", "b", "c");
                Console.WriteLine(abc);


            }

            static void Variables()
            {
                int x = -1;

                int y;
                y = 2;

                //Int32 x1 = -1;

                //unit z = -1;

                float f = 1.1f;

                double d = 2.3;

                int x2 = 0;
                int x3 = new int();

                var a = 1;

                //Dictionary<int, string> dict = new Dictionary<int, string>();
                //var dict = new Dictionary<int, string>();

                //var v

                decimal m = 1.1m;

                char c = 'a';

                string name = "JOHN";

                bool canDrive = true;
                bool canDraw = false;

                object obj1 = 1;

                object obj2 = "Hello";



                Console.WriteLine();
            }





        }

    }
}          
