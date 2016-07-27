using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;

namespace System
{
    public abstract class Hardware : Comp
    {
        private string name;

        private int maximumCapacity;
        private int maximumMemory;

        private int totalMemory;
        private int totalCapacity;

        protected Hardware(string name, int capacity, int memory) 
            : base(name, name, capacity, memory)
        {

        }
    }
}