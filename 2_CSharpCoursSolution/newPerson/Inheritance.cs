using System;
using System.Collections.Generic;
using System.Text;

namespace newPerson
{
    public class BankTerminal
    {
        protected string id;
        public BankTerminal(string id)
        {
            this.id = id;
        }
        public virtual void connect()
        {
            Console.WriteLine("General connecting protocol...");
        }
    }
    public class ModelXTerminal : BankTerminal
    {
        public ModelXTerminal(string id) : base(id)
        {
        }
        public override void connect()
        {
            base.connect();
            Console.WriteLine("Additional actions for Model X");
        }
    }
    public class ModelYTerminal : BankTerminal
    {
        public ModelYTerminal(string id) : base(id)
        {
        }
        public override void connect()
        {
            base.connect();
            Console.WriteLine("Actions for Model Y");
        }


    }
}