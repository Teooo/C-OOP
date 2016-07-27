using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfPredicates
{
    public static class Predicates
    {
        public static List<Func<int,bool>> predicates = new List<Func<int, bool>>();

        public static void AddPredicates(Func<int, bool> predicate)
        {
            predicates.Add(predicate);
        }

        public static List<int> ApplyPredicates(List<int> numbers)
        {
            List<int> result = new List<int>();
            bool legal = true;
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];
                foreach (var predicate in predicates)
                {
                    if (!predicate(currentNum))
                    {
                        legal = false;
                        break;
                    }
                }
                if (legal)
                {
                    result.Add(currentNum);
                }
                legal = true;
            }
            return result;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }
            int[] devisors = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var divisor in devisors)
            {
                Predicates.AddPredicates(x=>x % divisor == 0);
            }
            numbers = Predicates.ApplyPredicates(numbers);
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
