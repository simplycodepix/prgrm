using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Дана послідовність з n дійсних чисел.Підрахувати кількість максимальних елементів.
//2. Підрахувати суму елементів, розташованих між першим максимальним і останнім мінімальними елементами.
//3. Знайти мінімум з позитивних елементів.

namespace sec_lab_02
{
    class Exercise1
    {
        static int[] BuildOneDimensionalArray()
        {
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] oneDimensionalArray = new int[size];

            for(int i = 0; i < size; i++)
            {
                oneDimensionalArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            return oneDimensionalArray;
        }

        static int CountMaxElements(int[] array)
        {
            int count = 0, max = array[0];

            foreach (int number in array)
            {
                if (number > max)
                {
                    max = number;
                    count++;
                }
            }

            return count;
        }

        static int GetFirstMaxPosition(int[] array)
        {
            int firstMaxPosition = 0, foundMax = 0, max = array[0];

            foreach (int number in array)
            {
                if (number > max)
                {
                    foundMax++;
                }

                if (foundMax == 0)
                {
                    firstMaxPosition++;
                }
            }

            return firstMaxPosition;
        }

        static int GetLastMinPosition(int[] array)
        {
            int minIndex = 0, min = array[0], lastMinPosition = 0;

            foreach (int number in array)
            {
                if (number < min)
                {
                    min = number;
                    lastMinPosition = minIndex;
                }
                minIndex++;
            }

            return lastMinPosition;
        }

        static int GetSumOfElementsBetweenFirstMaxAndLastMin(int[] array)
        {
            int start, end, sum = 0;
            int firstMaxPosition = GetFirstMaxPosition(array);
            int lastMinPosition = GetLastMinPosition(array);

           if(firstMaxPosition < lastMinPosition)
           {
                start = firstMaxPosition;
                end = lastMinPosition;
           } else
            {
                start = lastMinPosition;
                end = firstMaxPosition;
            }

           for (int i = start; i < end; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        public Exercise1()
        {
            int[] array = BuildOneDimensionalArray();
            Console.WriteLine($"Count max elements in array: {CountMaxElements(array)}");
            Console.WriteLine($"Sum of elements between first max and last min: {GetSumOfElementsBetweenFirstMaxAndLastMin(array)}");
        }
    }
}
