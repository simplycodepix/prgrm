using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_08
{
    class Exercise1
    {
        public static bool ParenthesesBalance(string input)
        {
            Stack<char> parentheses = new Stack<char>();

            foreach (char symbol in input)
            {
                if (symbol == '(')
                    parentheses.Push(symbol);

                if (symbol == ')')
                {
                    if (parentheses.Count > 0)
                    {
                        char lastSymbol = parentheses.Peek();

                        if (symbol == ')' && lastSymbol == '(')
                            parentheses.Pop();
                    }
                    else
                        return false;
                }
            }

            return parentheses.Count == 0;
        }
        public Exercise1()
        {
            try
            {
                string fileContent = File.ReadAllText(@"C:\MainFiles\projects\university\programming\labs\sec_lab_08\text.txt");

                if(ParenthesesBalance(fileContent))
                {
                    Console.WriteLine(fileContent);
                    Console.WriteLine("Input has proper parenthese balance");
                }
                else
                    Console.WriteLine("Isn't balanced");
            }
            catch(Exception ex) { Console.WriteLine(ex); }
        }
    }
}
