using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Base
    {
        public Base(String s)
        {
            Console.WriteLine("Called Base class constructor and String : " +s);
        }
        public String GetHash()
        {
            Console.WriteLine("Base Class GetHash() method called");
            return this.ToString();
        }

        public virtual void Test()
        {
            Console.WriteLine("Base Class Test Method");
        }

        public void Test2()
        {
            Console.WriteLine("Base Class Test2 Method");
        }
    }
}
