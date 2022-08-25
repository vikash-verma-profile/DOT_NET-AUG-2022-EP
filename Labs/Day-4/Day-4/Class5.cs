using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    interface IManufacturer
    {
        void Discount();
    }
    interface IWholeSeller
    {
        void Discount();
    }
    class C : IManufacturer, IWholeSeller
    {
        void IManufacturer.Discount()
        {
            Console.WriteLine("Discount of Manufacturer");
        }
        void IWholeSeller.Discount()
        {
            Console.WriteLine("Discount of wholeseller");
        }
    }
    class Class5
    {

        public static void Main()
        {
            //C a = new C();
            //a.Discount();
            IManufacturer m = new C();
            m.Discount();

            IWholeSeller W = new C();
            W.Discount();
        }
    }
}
