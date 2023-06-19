using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Dz11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarCollection<cars> carCollection = new CarCollection<cars>(
            new cars("Car 1", 2022),
            new cars("Car 2", 2023)
        );

            carCollection.Add(new cars("Car 3", 2024));
            carCollection.Show();

            cars car = carCollection.Find(1);
            Console.WriteLine($"Car Name: {car.Name}, Year: {car.Year}");

            carCollection.Delete();
            carCollection.Show();
            carCollection.Add(new cars("Car 4", 2024));
            cars v = carCollection.Find(0);
            Console.WriteLine($"Car Name: {v.Name}, Year: {v.Year}");
        }
    }
    class cars
    {
        public string Name { get; }
        public int Year { get; }

        public cars(string name, int year)
        {
            Name = name;
            Year = year;
        }
    }

    class CarCollection<T> where T : cars
    {
        private T[] cars;
        public int NumberOfCars { get; private set; }
        public CarCollection(params T[] cars)
        {
            this.cars = cars;
            NumberOfCars = cars.Length;
        }

        public void Add(cars car)
        {
            Array.Resize(ref cars, cars.Length + 1);
            cars[cars.Length - 1] = (T)car;
            NumberOfCars = cars.Length;
        }
        public void Show()
        {
            Console.WriteLine($"Number Of cars {NumberOfCars}");
        }
        public void Delete()
        {
            cars = new T[0];
            NumberOfCars = 0;
        }
        public T Find(int index)
        {
            return cars[index];
        }
    }
}
