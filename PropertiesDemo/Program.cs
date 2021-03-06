﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    public class Program
    {
        public double _Radius = 45.33;

        /*public double GetRadius()
        {
            return Radius;
        }

        public void SetRadius(double value)
        {
            Radius = value;
        }*/

            //(or)

        public double Radius
        {
            get { return _Radius; }
            set 
            {   
                if(_Radius > value)
                _Radius = value; 
            }
        }
    }

    public class Test
    {
        static void Main()
        {
            Program p = new Program();

            /*Console.WriteLine("Radius : " + p.Radius);
            p.Radius = 65.33;
            Console.WriteLine("Radius : " + p.Radius);
            Console.ReadLine();*/

                    //(or)

            Console.WriteLine("Radius is : " + p.Radius);
            p.Radius = 43.22;
            Console.WriteLine("New Radius is : " + p.Radius);
            Console.ReadLine();
        }
    }
}
