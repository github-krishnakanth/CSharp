using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface IInterface1
    {
        void Test();
        void Show();
    }
    interface IInterface2
    {
        void Test();
        void Show();
    }
    class TestInterface : IInterface1, IInterface2
    {
        public void Test()
        {
            Console.WriteLine("Interfaces Test() method implemented in TestInterface Class..");
        }
        void IInterface1.Show()
        {
            Console.WriteLine("IInterface1 Show() method implemented in TestInterface Class..");
        }
        void IInterface2.Show()
        {
            Console.WriteLine("IInterface2 Show() method implemented in TestInterface Class..");
        }
        static void Main(string[] args)
        {
            TestInterface te = new TestInterface();
            te.Test();

            IInterface1 i1 = te;
            i1.Show();

            IInterface2 i2 = te;
            i2.Show();

            Console.ReadLine();
        }
    }
}
