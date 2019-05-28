using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_06
{
    class Exercise1
    {
        public Exercise1()
        {
            Square[] squares = new Square[4];

            squares[0] = new Square(3);
            squares[1] = new Square(1);
            squares[2] = new Square(5);
            squares[3] = new Square(2);
            Array.Sort(squares);

            foreach (Square square in squares)
            {
                square.PrintInfo();
            }
        }
    }
}
