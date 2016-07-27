using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInReversedOrder
{
    public class DecimalNumber
    {
        public decimal number;

        public DecimalNumber(decimal number)
        {
            this.number = number;
        }

        public decimal Number => this.number;

        public void ReverseNumber()
        {
            var numberToString = this.number.ToString();
            var result = string.Empty;
            for (int i = numberToString.Length-1; i >= 0; i--)
            {
                result += numberToString[i];
            }
            Console.WriteLine(result);
        }
    }
    class NumberInReversedOrder
    {
        static void Main()
        {
            decimal n = decimal.Parse(Console.ReadLine());
            DecimalNumber d = new DecimalNumber(n);
            d.ReverseNumber();
        }
    }
}
