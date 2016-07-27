using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace afasfafa
{
    class Program
    {
        public static int line = 1;
        static void Main(string[] args)
        {
           
            string input = Console.ReadLine();
            string pattern = @"\s*<\s*([a-z]+)\s+(?:value\s*=\s*""\s*(\d+)\s*""\s+)?[a-z]+\s*=\s*""([^""]*)""\s*\/>\s*";
            Regex regex = new Regex(pattern);

            while (input != "<stop/>")
            {
                Match match = regex.Match(input);

                string tag = match.Groups[1].Value;

                switch (tag)
                {
                    case "inverse":
                        ProcessInverseTag(match.Groups[3].Value);
                        break;
                    case "reverse":
                        ProcessReverseTag(match.Groups[3].Value);
                        break;
                       case "repeat":
                        ProcessRepeatTag(match.Groups[3].Value, int.Parse(match.Groups[2].Value));
                        break;
                }
                input = Console.ReadLine();
            }
        }

        private static void ProcessRepeatTag(string input, int repetitions)
        {
            if (repetitions > 0 && input.Length > 0)
            {
                for (int i = 0; i < repetitions; i++)
                {
                    Console.WriteLine($"{line++}. {input}");
                }
            }
        }

        private static void ProcessReverseTag(string input)
        {
            Console.WriteLine($"{line++}. {string.Join(string.Empty, input.Reverse())}");
        }

        private static void ProcessInverseTag(string value)
        {
            if (value.Length > 0)
            {
                StringBuilder sb = new StringBuilder();

                foreach (char ch in value)
                {
                    if (char.IsUpper(ch))
                    {
                        sb.Append(char.ToLower(ch));
                    }
                    else if (char.IsLower(ch))
                    {
                        sb.Append(char.ToUpper(ch));
                    }
                    else
                    {
                        sb.Append(ch);
                    }
                }
                Console.WriteLine($"{++line}. {sb}");
            }
        }
    }
}