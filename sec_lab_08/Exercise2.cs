using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_08
{
    class Exercise2
    {

        class Person
        {
            protected string name;
            protected string surname;
            public int age;
            protected int weight;

            public Person(string info)
            {
                string[] fields = info.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                this.name = fields[0];
                this.surname = fields[1];
                this.age = Convert.ToInt32(fields[2]);
                this.weight = Convert.ToInt32(fields[3]);
            }

            public void PrintInfo()
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine($"Name: {this.name}");
                Console.WriteLine($"Surname: {this.surname}");
                Console.WriteLine($"Age: {this.age}");
                Console.WriteLine($"Weight: {this.weight}");
            }
        }


        public Exercise2()
        {
            Queue peopleQ = new Queue();

            string line;
            StreamReader file = new StreamReader(@"C:\MainFiles\projects\university\programming\labs\sec_lab_08\people.txt");

            while ((line = file.ReadLine()) != null)
            {
                Person person = new Person(line);

                if (person.age < 40)
                    person.PrintInfo();
                else
                    peopleQ.Enqueue(person);
            }

            foreach(Person person in peopleQ)
            {
                person.PrintInfo();
            }

            file.Close();
        }
    }
}
