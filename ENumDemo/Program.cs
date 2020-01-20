using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENumDemo
{
    public enum Days : long
    {
        Monday = 1, Tuesday = 11, Wednesday = 21, Thrusday = 31, Friday = 41, Saturday = 51, Sunday = 4400
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Days d = 0;
            //Days d = (Days)1;
            //Days d = Days.Sunday;
            //Days d = Days.Sunday;
            //Console.WriteLine((int)d);

            /*foreach(string s in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(s);
            }*/

            /*foreach(int i in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine((Days)i);
            }*/

            foreach(long l in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(l);
            }

            Console.ReadLine();
        }
    }
}
