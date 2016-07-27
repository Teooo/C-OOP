using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carsInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();


            Automobile car = new Car(double.Parse(carsInfo[1]), double.Parse(carsInfo[2]));
            Automobile truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            int lineCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < lineCount; i++)
            {
                string[] command = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                double support = double.Parse(command[2]);
                if (command[1].Equals("Car"))
                {
                    if (command[0].Equals("Drive"))
                    {
                        car.Drive(support);
                    }
                    else if (command[0].Equals("Refuel"))
                    {
                        car.Refuel(support);
                    }
                }
                else if (command[1].Equals("Truck"))
                {
                    if (command[0].Equals("Drive"))
                    {
                        truck.Drive(support);
                    }
                    else if (command[0].Equals("Refuel"))
                    {
                        truck.Refuel(support);
                    }
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
        }
    }
}
