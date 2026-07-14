using System;

namespace CArraysCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var queue = new Queue<int>();
                queue.Enqueue(1);
                queue.Enqueue(2);
                queue.Enqueue(3);
                queue.Enqueue(4);
                Console.WriteLine($"Should print out 1:{queue.Peek()}");

                queue.Dequeue();

                Console.WriteLine($"Should print out 3:{queue.Peek()}");
                Console.WriteLine("Iterate aver the queue.");
                foreach (var cur in queue)
                { Console.WriteLine(cur); } 
            }

            static void StackType(string[] args)
            {
                var stack = new Stack<int>();
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                stack.Push(4);

                Console.WriteLine($"Should print out 4:{stack.Peek()}");

                stack.Pop();
                Console.WriteLine($"Should print out 3:{stack.Peek()}");
                Console.WriteLine("Iterate aver the stack.");
                foreach (var cur in stack)
                { Console.WriteLine(cur); }
            }


            static void ArryType(string[] args)
            {
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int index = Array.BinarySearch(numbers, 7);
                Console.WriteLine(index);

                int[] copy = new int[10];
                Array.Copy(numbers, copy, numbers.Length);

                int[] anotherCopy = new int[10];
                copy.CopyTo(anotherCopy, 0);

                Array.Reverse(copy);
                foreach (var c in copy)
                {
                    Console.WriteLine(c);
                }
                Console.WriteLine();

                int[] a1;
                a1 = new int[10];
                int[] a2 = new int[5];
                int[] a3 = new int[5] { 1, 3, -2, 5, 10 };
                int[] a4 = { 1, 3, 2, 4, 5 };
            }
        }
            






    }
}





