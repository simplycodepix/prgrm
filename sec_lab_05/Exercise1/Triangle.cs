using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_05
{
    class Triangle : Figure
    {
        protected int a, b, c;

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Perimeter()
        {
            return (a + b + c);
        }

        public override double Area()
        {
            double halfPerimeter = Perimeter() / 2;
            double calcPart = halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c);

            if (calcPart < 0)
            {
                Console.WriteLine("Triangle doesn't exist");
                return 0;
            }
            return Math.Round(Math.Sqrt(calcPart), 2);
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Triangle: ");
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
            Console.WriteLine($"Perimeter of triangle = {Perimeter()}");
            Console.WriteLine($"Area of triangle = {Area()}");
        }
    }
}
