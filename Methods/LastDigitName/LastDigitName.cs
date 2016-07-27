using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LastDigitName
{
    class LastDigitName
    {
        public class Number
        {
            public int number;

            public Number(int number)
            {
                this.number = number;
            }

            public int Numbera => this.number;

            public void  NameOfLastDigit()
            {
                var numberToStirng=this.number.ToString();
                var numberLength = numberToStirng.Length;
                switch (numberToStirng[numberLength-1])
                {
                    case '1':
                        Console.WriteLine("one");
                        break;
                    case '2':
                        Console.WriteLine("two");
                        break;
                    case '3':
                        Console.WriteLine("three");
                        break;
                    case '4':
                        Console.WriteLine("four");
                        break;
                    case '5':
                        Console.WriteLine("five");
                        break;
                    case '6':
                        Console.WriteLine("six");
                        break;
                    case '7':
                        Console.WriteLine("seven");
                        break;
                    case '8':
                        Console.WriteLine("eight");
                        break;
                    case '9':
                        Console.WriteLine("nine");
                        break;
                    case '0':
                        Console.WriteLine("zero");
                        break;
                }
                
            }
        }
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());

            Number n = new Number(a);
            n.NameOfLastDigit();
            
        }
    }
}
