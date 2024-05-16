using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> allCars = new List<Car>();
            

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();
                string model = inputArgs[0];
                double fuelAmount = double.Parse(inputArgs[1]);
                double fuelConsumptionFor1km = double.Parse(inputArgs[2]);
                
                allCars.Add(new Car(model, fuelAmount, fuelConsumptionFor1km, 0));
            }


            string inputDrive = Console.ReadLine();

            while (inputDrive != "End")
            {
                string[] driveArgs = inputDrive.Split();
                string carModel = driveArgs[1];
                double driveDistance = double.Parse(driveArgs[2]);

                foreach (var car in allCars)
                {
                    if (car.Model == carModel)
                    {
                        car.CalculateCarMove(car, driveDistance);
                    }
                }

                inputDrive = Console.ReadLine();
            }

            foreach (var car in allCars)
            {
                Console.WriteLine("{0} {1:F2} {2}",car.Model, car.FuelAmount, car.TraveledDistance);
            }
        }
    }
}
