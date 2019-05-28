using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_04
{
    class Ship
    {
        public string name, fuelType, destination;
        public double shipload, enginePower;

        public Ship()
        {
            Console.Write("Ship name: ");
            name = Console.ReadLine();
            Console.Write("Destination: ");
            destination = Console.ReadLine();
            Console.Write("Shipload: ");
            shipload = Convert.ToDouble(Console.ReadLine());
            Console.Write("Engine power: ");
            enginePower = Convert.ToDouble(Console.ReadLine());
            Console.Write("Fuel type: ");
            fuelType = Console.ReadLine();
        }

        public void PrintInfoAboutShip()
        {
            Console.WriteLine("Info about Aircraft Carrier");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Destination: {destination}");
            Console.WriteLine($"Shipload: {shipload}");
            Console.WriteLine($"Engine power: {enginePower}");
            Console.WriteLine($"Fuel type: {fuelType}");
        }

        public void PrintStuffOnBoard(List<NameAndCount> loadedStuff, string stuffName)
        {
            foreach (NameAndCount item in loadedStuff)
            {
                Console.WriteLine($"{stuffName}: {item.name}, count: {item.count}");
            }
        }
    }

    class NameAndCount
    {
        public string name;
        public int count;
    }

    class AircraftCarrier: Ship
    {
        protected List<NameAndCount> airplanes = new List<NameAndCount> { };

        public AircraftCarrier(): base()
        {
            Console.Write("Do you wanna add airplane? (yes/no): ");
            string shouldContinue = Console.ReadLine();

            while (shouldContinue != "no")
            {
                NameAndCount airplane = new NameAndCount();
                Console.Write("Airplane: ");
                airplane.name = Console.ReadLine();
                Console.Write("Count: ");
                airplane.count = Convert.ToInt32(Console.ReadLine());

                airplanes.Add(airplane);

                Console.Write("Do you wanna add another airplane? (yes/no): ");
                shouldContinue = Console.ReadLine();
            }
        }
        
        public void PrintInfoAboutAircraftCarrier()
        {
            PrintInfoAboutShip();
            Console.WriteLine("List of Airplanes on board: ");
            PrintStuffOnBoard(airplanes, "airplane");
        }
    }

    class Exercise3
    {
        public Exercise3()
        {
            AircraftCarrier aircraftCarrier = new AircraftCarrier();
            aircraftCarrier.PrintInfoAboutAircraftCarrier();
        }
    }
}
