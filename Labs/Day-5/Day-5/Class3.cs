using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    interface IVehiculo
    {
        void Drive();
        bool Refuel(int amount);
    }
    class Car : IVehiculo
    {
        int Fuel;

        public Car(int fuel)
        {
            Fuel = fuel;
        }
        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("Car is driving");
            }
            else
            {
                Console.WriteLine("No fuel");
            }
        }

        public bool Refuel(int amount)
        {
            Fuel = Fuel + amount;
            return true;
        }
    }
    class Class3
    {
        public static void Main4()
        {
            Car c = new Car(0);
            int fuel = int.Parse(Console.ReadLine());
            if (c.Refuel(fuel))
            {
                c.Drive();
            }
        }
    }
}
