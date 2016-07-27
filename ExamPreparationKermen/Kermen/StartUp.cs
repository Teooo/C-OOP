using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kermen.Factories;

namespace Kermen
{
    public class StartUp
    {
        static void Main()
        {
            List<HouseHold> kermen = new List<HouseHold>();
            string input = Console.ReadLine();
            int counter = 0;
            while (input != "Democracy")
            {
                counter++;
                try
                {
                    HouseHold entities = HouseHoldFactory.CrateHouseHold(input);
                    kermen.Add(entities);
                }
                catch (Exception)
                {

                    
                }
                if (counter % 3 == 0)
                {
                    kermen.ForEach(x=> x.GetIncome());
                }
                if (input == "EVN bill")
                {
                    kermen.RemoveAll(x => !x.CanPayBills());
                    kermen.ForEach(x=>x.PayBills());
                }
                else if (input == "EVN")
                {
                    Console.WriteLine($"Total consumption: {kermen.Sum(x=>x.Consumtion)}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total population: {kermen.Sum(x => x.Population)}");
        }
    }
}
