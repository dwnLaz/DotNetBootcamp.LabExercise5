using System;

namespace Lab5.Solution4
{
    internal class Program
    {
        interface IVehicle
        {
            void Drive();
            bool Refuel(int amount);
        }

        class Car : IVehicle
        {
            public int Fuel { get; set; }

            public Car(int fuel)
            {
                Fuel = fuel;
            }

            public void Drive()
            {
                if (Fuel > 0)
                {
                    Console.WriteLine("Driving");
                }
                else
                {
                    Console.WriteLine("No fuel");
                }
            }

            public bool Refuel(int amount)
            {
                Fuel += amount;
                return true;
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Car car = new Car(0);
                try
                {
                    Console.Write("Enter amount of fuel: ");
                    int fuel = int.Parse(Console.ReadLine());
                    if (car.Refuel(fuel))
                    {
                        car.Drive();
                        break;
                    }
                }
                catch
                { 
                    Console.WriteLine("Invalid Input");
                    continue;
                }
            }
        }
    }
}
