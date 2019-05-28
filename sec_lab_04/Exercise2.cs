using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_04
{
    class Exercise2
    {
        class A
        {
            public int a, b;
            public A (int a, int b)
            {
                this.a = a;
                this.b = b;
            }
        }

        class B : A
        {
            public int d;

            public B(int a, int b) : base(a, b) { }

            static B()
            {

            }

            public int C2
            {
                get { return a * b * d; }
            }
        }

        public Exercise2()
        {
            
        }
    }
}
