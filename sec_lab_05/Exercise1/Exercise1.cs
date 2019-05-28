using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_05
{
    class Exercise1
    {
        public Exercise1()
        {
            Triangle trngl = new Triangle(3, 2, 4); // TODO read from file
            trngl.PrintInfo();

            Console.WriteLine(Environment.NewLine);

            Rectangle rctngl = new Rectangle(2, 3); // TODO read from file
            rctngl.PrintInfo();

            Console.WriteLine(Environment.NewLine); // TODO read from file

            Circle crcl = new Circle(3);
            crcl.PrintInfo();
        }
    }
}
