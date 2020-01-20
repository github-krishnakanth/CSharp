using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    public abstract class Figure
    {
        public double Width, Height, Radius;
        public const float pi = 3.14f;

        public abstract double GetArea();
    }
    class Rectangle : Figure
    {
        public Rectangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }
    class Circle : Figure
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public override double GetArea()
        {
            return pi * Radius * Radius;
        }
    }
    class Test
    {
        static void Main()
        {
            Rectangle r = new Rectangle(4, 5);
            Circle c = new Circle(5);

            Console.WriteLine("Area of Rectangle is : " + r.GetArea());
            Console.WriteLine("Area of Circle is : " + c.GetArea());
            
            Console.ReadLine();
        }
    }
}
