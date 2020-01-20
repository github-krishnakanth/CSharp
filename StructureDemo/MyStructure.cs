using System;

namespace StructureDemo
{
    struct Structure1
    {
        int i;

        public void Show()
        {
            Console.WriteLine("Structure1 Show() method called.."+i);
        }
        static void Main()
        {
            Structure1 s1;
            s1.i = 20;
            s1.Show();
        }
    }
}