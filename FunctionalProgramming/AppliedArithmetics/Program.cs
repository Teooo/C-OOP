using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppliedArithmetics
{
    public static class Functions
    {
        public static void Print(List<int> collection, Action<List<int>> act)
        {
            act(collection);
        }
        public static List<int> ApplyFunc(List<int> collection, Func<int, int> func)
        {
            
            List<int> result = new List<int>();
            foreach (var item in collection)
            {
                int modifiedItem = func(item);
                result.Add(modifiedItem);
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
          
            string command = Console.ReadLine();
            while (command !="end")
            {
                switch (command)
                {
                    case "add":
                        Func<int, int> add = n => n + 1;
                        numbers=Functions.ApplyFunc(numbers, add);
                        break;
                    case "multiply":
                        Func<int, int> multiply = n => n * 2;
                        numbers=Functions.ApplyFunc(numbers, multiply);
                        break;
                    case "subtract":
                        Func<int, int> subtract = n => n - 1;
                        numbers=Functions.ApplyFunc(numbers, subtract);
                        break;
                    case "print":
                       
                        Functions.Print(numbers,x=>Console.WriteLine(string.Join(" ",numbers)));
                        break;
                }
               
                command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

            }
        }
    }
}
