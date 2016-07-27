using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] input = Console.ReadLine().Split();
        List<string> names = new List<string>();
        for (int i = 0; i < input.Length; i++)
        {
            Predicate<string> c = a => a.Length <= n;
            if (c(input[i]))
            {
                names.Add(input[i]);
            }
        }
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}

