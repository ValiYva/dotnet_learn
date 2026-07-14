
using System;
using System.Security.Claims;
namespace Csharpnew;
    class Program
{
    static void Main(string[] args)
    {
        MyStack<int> stack = new MyStack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        
       
        Console.WriteLine(stack.Peek()); // Output: 3
        stack.Pop();
        Console.WriteLine(stack.Peek()); // Output: 2
    }
}






