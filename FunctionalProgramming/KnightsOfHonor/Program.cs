using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Action<string> print = n => Console.WriteLine("Sir " + n);
            foreach (var i in input)
            {
                print(i);
            }
        }
    }
}
