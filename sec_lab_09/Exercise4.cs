using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_09
{
    class Exercise4
    {
        delegate int Operation(int a, int b);
        public Exercise4()
        {
            Dictionary<String, Operation> op = new Dictionary<String, Operation>();
            op["add"] = (a, b) => a + b;
            op["div"] = (a, b) => a / b;
            op["mult"] = (a, b) => a * b;
            Console.WriteLine(op["add"](5, 3));
            Console.WriteLine(op["mult"](6, 7));
            Console.WriteLine(op["div"](25, 5));
            Console.ReadLine();
        }
    }
}
