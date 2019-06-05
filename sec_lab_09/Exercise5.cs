using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_09
{
    class Exercise5
    {
        delegate int UseOperation(int a, int b);
        delegate void GetGreeting();
        public Exercise5()
        {
            GetGreeting greetingMessage;

            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour <= 12)
                greetingMessage = GoodMorning;
            else if (DateTime.Now.Hour > 12 && DateTime.Now.Hour <= 17)
                greetingMessage = GoodDay;
            else if (DateTime.Now.Hour > 17 && DateTime.Now.Hour <= 20)
                greetingMessage = GoodEvening;
            else if (DateTime.Now.Hour > 20 || DateTime.Now.Hour < 6)
                greetingMessage = GoodNight;
            else
                greetingMessage = SayHello;

            greetingMessage.Invoke();


            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b: ");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.Write("Operation (sum/sub/div/mult): ");
            string operation = Console.ReadLine();
            UseOperation useOperation;

            switch(operation)
            {
                case "sum":
                    useOperation = Sum;
                    break;
                case "sub":
                    useOperation = Subtraction;
                    break;
                case "div":
                    useOperation = Division;
                    break;
                case "mult":
                    useOperation = Multiplication;
                    break;
                default:
                    Console.WriteLine("nothing to invoke");
                    return;
            }

            Console.WriteLine($"{operation} = {useOperation.Invoke(a, b)}");
        }

        public static void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }

        public static void GoodDay()
        {
            Console.WriteLine("Good Day");
        }

        public static void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }
        public static void GoodNight()
        {
            Console.WriteLine("Good Night!");
        }
        public static void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        public static int Division(int a, int b)
        {
            return a / b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

    }
}
