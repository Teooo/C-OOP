using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        for (int i = 0; i < input.Length; i++)
        {
            Predicate<int> c = a => a % n == 0;
            int currentNumber = int.Parse(input[i]);
            if (!c(currentNumber))
            {
                numbers.Add(currentNumber);
            }
        }
        numbers.Reverse();
        foreach (var g in numbers)
        {
            Console.Write(g+" ");
        }
    }
}
