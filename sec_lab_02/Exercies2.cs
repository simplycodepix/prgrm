using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_02
{
    class Exercise2
    {
        static int[,] BuildMatrix()
        {
            Console.Write("Enter n: ");

            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            return matrix;
        }

        static void PrintTwoDimensionalArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", array[i, j]));
                }
                Console.Write(Environment.NewLine);
            }
        }

        static double GetAverageOfOddElements(int[,] array)
        {
            int sum = 0, countElements = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = i + 1; j < array.GetLength(1); j++)
                {
                    if (array[i, j] != 0)
                    {
                        sum += array[i, j];
                        countElements++;
                    }
                }
            }

            return sum / countElements;
        }

        static double GetAverageOfElementsOnCounterDiagonal(int[,] array)
        {
            int sum = 0, countElements = 0;
            double result;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[i, j] != 0)
                    {
                        sum += array[i, j];
                        countElements++;
                    }
                }
            }

            result = sum / countElements;

            return result;
        }

        public Exercise2()
        {
            int[,] array = BuildMatrix();

            PrintTwoDimensionalArray(array);

            Console.WriteLine($"Average of odd elements = {GetAverageOfOddElements(array)}");
            Console.WriteLine($"Average of elements on counter diagonal = {GetAverageOfElementsOnCounterDiagonal(array)}");
        }
    }
}
