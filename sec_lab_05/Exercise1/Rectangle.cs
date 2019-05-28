using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_05
{
    class Rectangle: Figure
    {
        protected int a, b;
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public override double Perimeter()
        {
            return 2 * a + 2 * b;
        }
        public override double Area()
        {
            return a * b;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Rectangle: ");
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"Perimeter of rectangle = {Perimeter()}");
            Console.WriteLine($"Area of rectangle = {Area()}");
        }
    }
}
