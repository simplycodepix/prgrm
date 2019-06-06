using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_09
{
    class Program
    {
        enum Excercises { STOP, FIRST, SECOND, THIRD, FOURTH, FIFTH };
        static void Main(string[] args)
        {
            int excercise;
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Choose Excercise from 1 to 5: (type 0 to quit)");
                excercise = Convert.ToInt32(Console.ReadLine());

                switch (excercise)
                {
                    case (int)Excercises.STOP:
                        flag = false;
                        break;
                    case (int)Excercises.FIRST:
                        new Exercise1();
                        break;
                    case (int)Excercises.SECOND:
                        new Exercise2();
                        break;
                    case (int)Excercises.THIRD:
                        new Exercise3();
                        break;
                    case (int)Excercises.FOURTH:
                        new Exercise4();
                        break;
                    case (int)Excercises.FIFTH:
                        new Exercise5();
                        break;
                    default:
                        Console.WriteLine("It's too much");
                        break;
                }
            }
        }
    }
}
