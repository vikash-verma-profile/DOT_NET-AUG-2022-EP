using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    class Vehicle
    {
        string FuelType;
        int ChasseyNo;

        public void GetData()
        {
            Console.WriteLine("Please enter FuelType");
            FuelType = Console.ReadLine();
            Console.WriteLine("Please enter Chassey Number");
            ChasseyNo = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintDetails()
        {
            Console.WriteLine("Fuel Type :" + FuelType);
            Console.WriteLine("Chassey Number :" + ChasseyNo);
        }
    }
    //<colon><class-name>
    class Car: Vehicle
    {
        string CarModel;

        public void GetCarDetails()
        {
            GetData();
            Console.WriteLine("Please enter CarModel");
            CarModel = Console.ReadLine();
        }
        public void PrintCarDetails()
        {
            Console.WriteLine("You Car is ");
            PrintDetails();
            Console.WriteLine("Car Model :"+CarModel);
        }
    }
    class Class4
    {
        /// <summary>
        /// Single Inheritance
        /// </summary>
        public static void Main5()
        {
            Car c = new Car();
            c.GetCarDetails();
            c.PrintCarDetails();
        }
    }
}
