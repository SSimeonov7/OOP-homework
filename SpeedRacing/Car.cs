using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionFor1km;
        private double traveledDistance;

        public Car(string model, double fuelAmount, double fuelConsumptionFor1km, double traveledDistance)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionFor1km = fuelConsumptionFor1km;
            this.TraveledDistance = 0;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public double FuelConsumptionFor1km
        {
            get { return this.fuelConsumptionFor1km; }
            set { this.fuelConsumptionFor1km = value; }
        }

        public double TraveledDistance
        {
            get { return this.traveledDistance; }
            set { this.traveledDistance = value; }
        }

        public void  CalculateCarMove(Car car, double distance)
        {
            if ((car.fuelConsumptionFor1km * distance) > car.fuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                double traveled = car.fuelConsumptionFor1km * distance;
                car.fuelAmount -= traveled;
                car.traveledDistance += distance;
            }
        }
    }
}
