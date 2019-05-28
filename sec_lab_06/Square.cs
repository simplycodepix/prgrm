using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_06
{
    class Square: IComparable<Square>
    {
        protected int side;
        public Square(int side)
        {
            this.side = side;
        }
        public int Perimeter()
        {
            return 4 * this.side;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Side = {side} and Perimeter = {Perimeter()}");
        }
        public int CompareTo(Square obj)
        {
            return this.Perimeter().CompareTo(obj.Perimeter());
        }
    }
}
