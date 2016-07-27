using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public class Software  : Comp
    {
        protected Software(string name, string type,int capacity,int memory) 
            : base(name,type, capacity, memory)
        {
          
        }

      
    }
}