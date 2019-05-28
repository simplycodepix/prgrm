using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//зводити в зазначену ступінь, обчислювати
//квадратний корінь, обчислювати відсотки

namespace sec_lab_01
{
    class Exercise5
    {
        public Exercise5()
        {
            char operation;

            Console.WriteLine(@"
                Operators:
                ^ - pow numbers
                s - sqrt number
                % - calc percent
            ");
            Console.Write("Choose operation: ");

            operation = Convert.ToChar(Console.ReadLine());

            switch(operation)
            {
                case '^':
                    PowNumbers();
                    break;
                case 's':
                    SqrtNumber();
                    break;
                case '%':
                    CalcPercentage();
                    break;
                default:
                    Console.WriteLine("comming soon! Subscribe for updates");
                    break;
            }
        }

        void PowNumbers()
        {
            double num, power, result;

            Console.Write("Number: ");
            num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Power: ");
            power = Convert.ToDouble(Console.ReadLine());

            result = Math.Round(Math.Pow(num, power), 2);

            PrintResult(result);
        }

        void SqrtNumber()
        {
            double num, result;

            Console.Write("Number: ");
            num = Convert.ToDouble(Console.ReadLine());

            result = Math.Round(Math.Sqrt(num), 2);

            PrintResult(result);
        }

        void CalcPercentage()
        {
            double num, percent, result;

            Console.Write("Number: ");
            num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Percent: ");
            percent = Convert.ToDouble(Console.ReadLine());

            result = num * (percent / 100);

            PrintResult(result);
        }

        void PrintResult(double result)
        {
            Console.WriteLine($"Result = {result}");
        }
    }
}
