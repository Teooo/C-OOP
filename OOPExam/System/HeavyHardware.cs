using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public class HeavyHardware : Hardware
    {
        public HeavyHardware(string name, int maxCapacity, int maxMemory) 
            : base(name, maxCapacity, maxMemory)
        {
        }

        public override int Capacity 
        {
            get { return base.Capacity + (this.Capacity-(this.Capacity / 4)); }
            
        }

        public override int Mememory
        {
            get
            {
                return base.Mememory +(base.Mememory + (this.Mememory / 4));
            }
        }
    }
}