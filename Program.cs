using System;
using System.Formats.Asn1;

namespace CSharpCours
{
    class Program
    {
        static void Main(string[] args)
        {
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

                bool endWithAbra = name.EndsWith ("ebra");
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
