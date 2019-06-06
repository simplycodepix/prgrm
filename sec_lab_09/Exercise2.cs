using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace sec_lab_09
{
    class Exercise2
    {
        public Exercise2()
        {
            string fileContent = File.ReadAllText(@"C:\MainFiles\projects\university\programming\labs\sec_lab_09\TextFile1.txt");

            Action<string> act;
            act = PrintAllText;
            ReadFiles(fileContent, act);
            Console.WriteLine(Environment.NewLine);

            act = PrintAllNumbers;
            ReadFiles(fileContent, act);
            Console.WriteLine(Environment.NewLine);

            act = CleanUpString;
            ReadFiles(fileContent, act);
        }

        static void ReadFiles(string fileContent, Action<string> act)
        {
            act(fileContent);
        }

        static void PrintAllText(string text)
        {
            Console.WriteLine(text);
        }

        static void PrintAllNumbers(string text)
        {
            string[] numbers = Regex.Split(text, @"\D+");
            StringBuilder numbersString = new StringBuilder();

            foreach (string number in numbers)
            {
                if (!string.IsNullOrEmpty(number))
                {
                    int i = int.Parse(number);
                    numbersString.Append(number + " ");
                }
            }
            Console.WriteLine(numbersString.ToString());
        }

        static void CleanUpString(string text)
        {
            string[] stringParts = text.Split(new char[] { ',', '.', '*', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            string cleanedString = string.Join(" ", stringParts);
            Console.WriteLine(cleanedString);
        }

    }
}
