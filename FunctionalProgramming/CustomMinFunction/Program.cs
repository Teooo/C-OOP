using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            HashSet<int> numbers = new HashSet<int>();
            foreach (var item in input)
            {
                numbers.Add(int.Parse(item));
            }
            Func<HashSet<int>, int> myFunc = a => a.Min();
            int c =myFunc(numbers);
            Console.WriteLine(c);
        }
    }
}
