using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_04
{
    class Exercise1
    {
        class ProductNumbers
        {
            public int a, b;

            public int C
            {
                get { return a * b; }
            }
        }


        public Exercise1()
        {
            ProductNumbers objectA = new ProductNumbers
            {
                a = 2,
                b = 4
            };
            Console.WriteLine($"a = {objectA.a}, b = {objectA.b}");
            Console.WriteLine($"C = {objectA.C}");
        }
    }


}
