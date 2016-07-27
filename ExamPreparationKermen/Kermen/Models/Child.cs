using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kermen
{
    public class Child
    {
        private decimal[] consumations;

        public Child(decimal[] consumations)
        {
            this.consumations = consumations;
        }

        public decimal GetTotalConsumation()
        {
            return this.consumations.Sum();
        }
    }
}