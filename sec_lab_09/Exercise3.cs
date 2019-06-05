using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_09
{
    class Exercise3
    {
        delegate double Operation(double a);

        public Exercise3()
        {
            Operation operation;

            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            operation = CircleLength;
            Console.WriteLine($"Length: {operation.Invoke(radius)}");
            operation = CircleArea;
            Console.WriteLine($"Area: {operation.Invoke(radius)}");
            operation = CircleVolume;
            Console.WriteLine($"Volume: {operation.Invoke(radius)}");
        }

        public static double CircleLength(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public static double CircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double CircleVolume(double radius)
        {
            return (4/3) * Math.PI * Math.Pow(radius, 3);
        }
    }
}
