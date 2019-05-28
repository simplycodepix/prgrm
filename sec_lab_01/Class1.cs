using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_01
{
    public class Exercise1
    {
        double a, b, c, angle, perimeter, area;

        public Exercise1()
        {
            Console.WriteLine("Enter side and angle: ");
            Console.Write("side: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("angle: ");
            angle = Convert.ToDouble(Console.ReadLine());

            CalculateOtherSides();
            perimeter = getPerimeter(a, b, c);
            area = getAreaByTwoSides(a, b);

            Console.WriteLine("Perimeter = " + perimeter);
            Console.WriteLine("Area = " + area);
        }

        void CalculateOtherSides()
        {
            double radians = angle * (Math.PI / 180);

            b = Math.Round(Math.Abs(a / Math.Tan(radians)), 2);

            c = Math.Round(Math.Sqrt(a * a + b * b), 2);
        }

        double getPerimeter(double a, double b, double c)
        {
            return (a + b + c);
        }

        double getAreaByTwoSides(double a, double b)
        {
            return (a * b) / 2;
        }

    }
}
