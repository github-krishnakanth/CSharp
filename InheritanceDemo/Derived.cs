using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Derived : Base
    {
        public Derived(String s) : base("Base Class")
        {
            Console.WriteLine("Called Derived class constructor and String : "+s);
        }

        // Overriding Base's Test method in Derived class
        public override void Test()
        {
            Console.WriteLine("Derived Class Test Method");
        }
        // Overloading Base class GetHash() method in Derived class
        public String GetHash(string s)
        {
            return s.ToString();
        }

        public new void Test2() // Method Hiding/Shadowing
        {
            Console.WriteLine("Child Class Test2 Method");
        }
        public void BaseTest()
        {
            base.Test();
        }

        static void Main()
        {
            Base b = new Base("Base Class");
            b.Test();
            Derived d2 = new Derived("Derived Class");
            Base b2 = d2;
            b2.Test();
            b2.Test2();
            Derived d = new Derived("Derived Class");
            d.BaseTest();
            d.Test();
            d.Test2();
            Console.WriteLine(d.GetHash("Derived Class"));
        }
    }
}
