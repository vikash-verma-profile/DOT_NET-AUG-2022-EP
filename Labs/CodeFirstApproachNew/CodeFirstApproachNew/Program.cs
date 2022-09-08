using CodeFirstApproachNew.Models;
using System;

namespace CodeFirstApproachNew
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesDbContext db = new SalesDbContext();
            Sales obj = new Sales();
            obj.SalesPerson = "Vikash";
            obj.TotalSales = 1000.00;
            db.Sales.Add(obj);
            db.SaveChanges();
            Console.WriteLine("Record is saved");
        }
    }
}
