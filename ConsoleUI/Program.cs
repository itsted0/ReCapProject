using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Car denemeCar1 = new Car { Id = 4, ColorId = 3, BrandId = 5, Description = "Ferrari", DailyPrice = 15000, ModelYear = 2020 };
            carManager.Add(denemeCar1);
            Console.WriteLine("Added---->" + carManager.GetById(4).Description);

            carManager.Delete(denemeCar1);
            // Alt satır System.NullReferenceException hatası verecektir.
            // Console.WriteLine("Deleted" + carManager.GetById(4).Description); 
        }
    }
}
