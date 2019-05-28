using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_05
{
    class Circle: Figure
    {
        protected double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Perimeter()
        {
            return Math.Round(2 * Math.PI * radius, 2);
        }
        public override double Area()
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Circle: ");
            Console.WriteLine($"Radius = {radius}");
            Console.WriteLine($"Perimeter of a circle = {Perimeter()}");
            Console.WriteLine($"Area of a circle = {Area()}");
        }

    }
}
