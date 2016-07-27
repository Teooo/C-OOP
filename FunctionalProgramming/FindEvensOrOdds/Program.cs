using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string command = Console.ReadLine();
            int start = int.Parse(input[0]);
            int end = int.Parse(input[1]);
            List<int> odd = new List<int>();
            List<int> even = new List<int>();
            Predicate<int> pre = a => a % 2 == 1 || a % 2 !=0;
            for (int i = start; i <= end; i++)
            {
                if (pre(i))
                {
                    odd.Add(i);
                }
                else
                {
                    even.Add(i);
                }
            }
            if (command == "odd")
            {
                foreach (var o in odd)
                {
                    Console.Write(o+" ");
                }
            }else if (command == "even")
            {
                foreach (var e in even)
                {
                    Console.Write(e+ " ");
                }
            }
        }
    }
}
