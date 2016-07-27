using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Automobile
    {
        private double fuelQuantity;
        private double fuelConsumption;


        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            protected set { this.fuelQuantity = value; }
        }

        public double FuelConsumtion
        {
            get { return this.fuelConsumption; }
            protected set { this.fuelConsumption = value; }
        }

        public Automobile(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumtion = fuelConsumption;
        }

        public abstract void Drive(double distance);
        public abstract void Refuel(double fuel);
    }
}
