using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_01
{
    public class Car
    {
        public int modelID;
        public double price;
        public int year;

        public Car()
        {
            Console.Write("modelID: ");
            this.modelID = Convert.ToInt32(Console.ReadLine());
            Console.Write("price: ");
            this.price = Convert.ToDouble(Console.ReadLine());
            Console.Write("year: ");
            this.year = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Exercise3
    {
        public Exercise3()
        {
            int carsCount = 0, desireModelID, maxCars;
            List<Car> cars = new List<Car>();

            Console.Write("Cars count: ");
            maxCars = Convert.ToInt32(Console.ReadLine());

            while(carsCount < maxCars)
            {
                cars.Add(new Car());
                carsCount++;
            }

            Console.Write("Desire car model: ");
            desireModelID = Convert.ToInt32(Console.ReadLine());

            foreach(Car car in cars)
            {
                if (car.modelID == desireModelID)
                {
                    Console.WriteLine($"Car model: {car.modelID}");
                    Console.WriteLine($"Car price: {car.price}$");
                    Console.WriteLine($"Car year: {car.year}");
                }
            }
        }
    }
}
