using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionPrint1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Action<string> print = message => Console.WriteLine("Sir "+message);
            foreach (var i in input)
            {
                print(i);
            }

        }
    }
}
