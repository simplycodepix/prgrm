using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_02
{
    class Exercise3
    {
        static int[] BuildOneDimensionalArray()
        {
            Console.Write("Enter size of array: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] oneDimensionalArray = new int[arraySize];

            Console.WriteLine("Numbers: ");
            for(int i = 0; i < arraySize; i++)
            {
                oneDimensionalArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            return oneDimensionalArray;
        }

        static int FindMinimalNumberPosition(ref int[] array)
        {
            int minimalNumberPosition = 0;
            int minimal = array[minimalNumberPosition];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minimal)
                {
                    minimal = array[i];
                    minimalNumberPosition = i;
                }
            }

            return minimalNumberPosition;
        }

        static void PrintOneDimensionalArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(string.Format("{0} ", array[i]));
            }
            Console.Write(Environment.NewLine);
        }

        public Exercise3()
        {
            int[] firstArray = BuildOneDimensionalArray();
            int minimalNumberPosition = FindMinimalNumberPosition(ref firstArray) + 1,
                firstArrayLength = firstArray.Length,
                secondArraySize = firstArrayLength - minimalNumberPosition;

            Console.WriteLine($"MinimalNumberPosition = {minimalNumberPosition}, secondArraySize = {secondArraySize}");

            int[] secondArray = new int[secondArraySize];
            int index = 0;
            for (int i = minimalNumberPosition; i < firstArrayLength; i++)
            {
                secondArray[index] = firstArray[i];
                index++;
            }

            Console.WriteLine("First array: ");
            PrintOneDimensionalArray(firstArray);
            Console.WriteLine("Second array: ");
            PrintOneDimensionalArray(secondArray);
            Console.WriteLine("Second array after sort: ");
            PrintOneDimensionalArray(secondArray.OrderByDescending(c => c).ToArray());
        }
    }
}
