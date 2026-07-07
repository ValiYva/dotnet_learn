using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace newPerson
{
   

    internal class Person(string name, int age)

    {
        public Person(string name) : this(name, 18) { }
        public void Print() => Console.WriteLine($"Name: {name}, Age: {age}");
        
    }
    
}


