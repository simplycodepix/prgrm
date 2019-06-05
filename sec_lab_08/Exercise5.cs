using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_08
{
    class Exercise5
    {
        public Exercise5()
        {
            ArrayList numbersList = new ArrayList();
            Random random = new Random();

            for (int i = 0; i < 1850; i++)
            {
                numbersList.Add(random.Next(200, 700));
            }

            numbersList.Sort();


            foreach (int number in numbersList)
            {
                Console.WriteLine(number);
            }


            int newValue = random.Next(0, 1002);
            Console.WriteLine($"New value: {newValue}");

            int searchForNewValueIndex = numbersList.BinarySearch(newValue);
            if(searchForNewValueIndex > -1)
            {
                Console.WriteLine($"New value - {numbersList[searchForNewValueIndex]}, found at index = {searchForNewValueIndex}");
                Console.WriteLine($"Count before delete: {numbersList.Count}");
                numbersList.RemoveAt(searchForNewValueIndex);
                Console.WriteLine($"Count after delete: {numbersList.Count}");
            }

            numbersList.RemoveRange(0, numbersList.Count);

            Console.WriteLine($"Count after wipe: {numbersList.Count}");
        }
    }
}
