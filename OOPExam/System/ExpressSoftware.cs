using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public class ExpressSoftware : Software
    {
        public ExpressSoftware(string name, int capacity, int memory, string type) 
            : base(name, capacity, memory, type)
        {
        }
    }
}