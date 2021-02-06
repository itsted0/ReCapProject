using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Car denemeCar1 = new Car { Id = 4, ColorId = 3, BrandId = 5, Description = "Ferrari", DailyPrice = 15000, ModelYear = 2020 };
            carManager.Add(denemeCar1);
            // Console.WriteLine("Added---->" + carManager.GetById(4).Description);
            Console.WriteLine("Cars by brand id == 2 ---->" + carManager.GetCarsByBrandId(2));
            Console.WriteLine("Cars by brand id == 2 ---->" + carManager.GetCarsByColorId(1));

            carManager.Delete(denemeCar1);
            // Alt satır System.NullReferenceException hatası verecektir.
            // Console.WriteLine("Deleted" + carManager.GetById(4).Description); 
        }
    }
}
