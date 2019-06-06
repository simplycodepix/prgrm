using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_09
{
    class Exercise1
    {
        public Exercise1()
        {
            int arraySize = 5;
            Random random = new Random();
            int[,] matrix = new int[arraySize, arraySize];


            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    matrix[i,j] = random.Next(-10, 10);
                }
            }

            Action<int> act;

            act = Show;
            MethodAct(matrix, act);
            Console.WriteLine(Environment.NewLine);

            act = ShowPositive;
            MethodAct(matrix, act);
            Console.WriteLine(Environment.NewLine);

            Func<int, int> op;
            op = Mult3;
            MethodFunc(matrix, op);
        }

        static void MethodAct(int[,] arr, Action<int> act)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    act(arr[i, j]);
                }
                Console.WriteLine(Environment.NewLine);
            }
        }

        static void MethodFunc(int[,] arr, Func<int, int> act)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{act(arr[i, j])}  ");
                }
                Console.WriteLine(Environment.NewLine);
            }
        }
        static void Show(int num)
        {
            Console.Write($"{num} ");
        }

        static void ShowPositive(int num)
        {
            if(num >= 0)
                Console.Write($"{num} ");
        }
        static int Mult3(int num)
        {
            return num * 3;
        }
    }
}
