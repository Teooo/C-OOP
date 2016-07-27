using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public abstract class Comp
    {
        private string name;
        private int capacity;
        private int memory;
        private string type;

        protected Comp(string name,string type, int capacity, int memory)
        {
            this.name = name;
            this.capacity = capacity;
            this.memory = memory;
            this.type = type;
        }

        public virtual int Capacity
        {
            get { return this.capacity; }
        }
        public virtual int Mememory
        {
            get { return this.memory; }
        }
        
    }
}