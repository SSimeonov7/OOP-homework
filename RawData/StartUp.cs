using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();

                string model = inputArgs[0];
                int engineSpeed = int.Parse(inputArgs[1]);
                int enginePower = int.Parse(inputArgs[2]);
                int cargoWeght = int.Parse(inputArgs[3]);
                string cargoType = inputArgs[4];

                List<Tire> tireList = new List<Tire>();

                for (int j = 0; j < 4; j += 2)
                {
                    double tirePressure = double.Parse(inputArgs[5 + j]);
                    int tireAge = int.Parse(inputArgs[6 + j]);

                    tireList.Add(new Tire(tireAge, tirePressure));
                }

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeght, cargoType);

                Car car = new Car(model, engine, cargo, tireList);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            List<Car> resultCars = new List<Car>();

            if (command == "fragile")
            {
                resultCars = cars.Where(x => x.Cargo.CargoType == "fragile" &&
                                        x.Tire.Any(t => t.Pressure < 1)).ToList();
            }
            else
            {
                resultCars = cars.Where(x => x.Cargo.CargoType == "flamable" &&
                                        x.Engine.Power > 250).ToList();
            }

            foreach (var car in resultCars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
