using System;
using Vehicles;

public class Car : Automobile
{
    public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
    {
        this.FuelConsumtion += 0.9;
    }

    public override void Drive(double distance)
    {
        if (distance * this.FuelConsumtion <= this.FuelQuantity)
        {
            Console.WriteLine($"Car travelled {distance} km");
            this.FuelQuantity -= distance * FuelConsumtion;
        }
        else
        {
            Console.WriteLine($"Car needs refueling");
        }
    }

    public override void Refuel(double fuel)
    {
        this.FuelQuantity += fuel;
    }
}