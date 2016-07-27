using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<string> name = new List<string>();
            List<string> result = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                name.Add(input[i]);
                result.Add(input[i]);
            }
            string[] command = Console.ReadLine().Split();
            Predicate<string> removeStarsWith = r => r.StartsWith(command[2]);
            Predicate<string> removeEndsWith = r => r.EndsWith(command[2]);
            while (command[0] !="Party !")
            {
                switch (command[0])
                {
                    case "Remove":
                        
                        if (command[1] == "StartsWith")
                        {
                            foreach (var n in name)
                            {
                                if (removeStarsWith(n))
                                {
                                    result.Remove(n);
                                }
                            }
                        }else if (command[1] == "EndsWith")
                        {
                            foreach (var n in name)
                            {
                                if (removeEndsWith(n))
                                {
                                    result.Remove(n);
                                }
                            }
                        }
                        break;
                    case "Double":
                        if (command[1] == "StartsWith")
                        {
                            foreach (var n in name)
                            {
                                if (removeStarsWith(n))
                                {
                                    result.Add(n);
                                }
                            }
                        }else if (command[1] == "EndsWith")
                        {
                            foreach (var n in name)
                            {
                                if (removeEndsWith(n))
                                {
                                    result.Add(n);
                                }
                            }
                        }
                        else if(command[1] == "Length")
                        {
                            int lenght = int.Parse(command[2]);
                            Predicate<string> length = r => r.Length <= lenght;
                            foreach (var n in name)
                            {
                                if (length(n))
                                {
                                    result.Add(n);
                                }
                            }
                        }
                        break;
                }
                command = Console.ReadLine().Split();
                if (command[0] == "Party!")
                {
                    Console.WriteLine(string.Join(",", result)+ " are going to the party!");
                    break;
                }
            }
        }
    }
}
