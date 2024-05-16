using System;
using System.Collections.Generic;

namespace CarSalesman
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputEngins = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                AddEngins(engines, inputEngins);
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] inputCars = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                AddCars(cars, inputCars);
            }

            Print(cars, engines);
        }

        private static void Print(List<Car> cars, List<Engine> engines)
        {
            foreach (var car in cars)
            {
                Console.WriteLine("{0}:",car.Model);
                Console.WriteLine("  {0}:",car.Engine);
                foreach (var eng in engines)
                {
                    if (eng.Model == car.Engine)
                    {
                        Console.WriteLine("    Power: {0}", eng.Power);
                        Console.WriteLine("    Displacement: {0}", eng.Displacement);
                        Console.WriteLine("    Efficiency: {0}", eng.Efficiency);
                    }
                }
                Console.WriteLine("  Weight: {0}",car.Weight);
                Console.WriteLine("  Color: {0}",car.Color);
            }

        }

        private static void ToString(List<Car> cars, List<Engine> engines)
        {
            throw new NotImplementedException();
        }

        private static void AddEngins(List<Engine> engines, string[] inputEngins)
        {
            string model = inputEngins[0];
            string power = inputEngins[1];

            Engine eng = new Engine(model, power);

            if (inputEngins.Length == 3)
            {
                if (int.TryParse(inputEngins[2], out int result))
                {
                    eng.Displacement = inputEngins[2];
                }
                else
                {
                    eng.Efficiency = inputEngins[2];
                }
            }
            else if (inputEngins.Length == 4)
            {
                eng.Displacement = inputEngins[2];
                eng.Efficiency = inputEngins[3];
            }

            engines.Add(eng);
        }

        private static void AddCars(List<Car> cars, string[] inputCars)
        {
            string model = inputCars[0];
            string engine = inputCars[1];

            Car car = new Car(model, engine);

            if (inputCars.Length == 3)
            {
                if (int.TryParse(inputCars[2], out int result))
                {
                    car.Weight = inputCars[2];
                }
                else
                {
                    car.Color = inputCars[2];
                }
            }
            else if (inputCars.Length == 4)
            {
                car.Weight = inputCars[2];
                car.Color = inputCars[3];
            }

            cars.Add(car);
        }
    }
}
