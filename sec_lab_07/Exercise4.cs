using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_07
{
    class Exercise4
    {
        public Exercise4()
        {
            Stack numbers = new Stack();
            try
            {
                string fileContent = File.ReadAllText(@"C:\MainFiles\projects\university\programming\sec_lab_07\TextFile1.txt");
                string[] integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                int[] integers = new int[integerStrings.Length];

                for(int n = 0; n < integerStrings.Length; n++)
                {
                    integers[n] = int.Parse(integerStrings[n]);
                    Console.Write($"{integers[n]} ");
                    numbers.Push(integers[n]);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(Environment.NewLine);

            using (StreamWriter output = new StreamWriter("output.txt"))
            {
                int length = numbers.Count, currentNumber;

                for(int i = 0; i < length; i++)
                {
                    currentNumber = Convert.ToInt32(numbers.Pop());
                    Console.Write($"{currentNumber} ");
                    output.Write($"{currentNumber} ");
                }
            }
        }
    }
}
