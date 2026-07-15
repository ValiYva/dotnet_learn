using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Csharpnew
{
    public class MyStack<T>
    {
        private string _name;
        public string MyName = "Artem";

        public int Count { get; private set; }
        public int Capacity
        {
            get
            {
                return _items.Length;
            }
        }
            public MyStack()
        {
            const int defaultCapacity = 4;
            _items = new T[defaultCapacity];
        }
        public MyStack(int capacity) 
        {
            _items = new T[capacity];
        }

        public void Push(T item)
        {
            if (_items.Length == Count)
            {
                T[] largerArray = new T [Count * 2];
                Array.Copy(_items, largerArray, Count);

                _items = largerArray;
            }
            
            _items[Count++] = item;
                      
        }

        public void Pop()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            _items[--Count] = default;
        }
        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return _items[Count - 1];
        }
}
}
