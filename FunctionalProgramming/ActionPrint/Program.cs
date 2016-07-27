using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ActionPrint
{
    class Program
    {
        Action<string> myAction;

        public static void Print(int a)
        {
            Console.WriteLine(a);
        }
    }
}
