using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car {Id = 1, BrandId=1, ColorId = 1, DailyPrice = 1000, Description = "Hiper", ModelYear = 1900 },
                new Car {Id = 2, BrandId=2, ColorId = 2, DailyPrice = 2000, Description = "Hiperv2", ModelYear = 2500 },
                new Car {Id = 3, BrandId=2, ColorId = 1, DailyPrice = 1500, Description = "Super", ModelYear = 700 },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _cars.SingleOrDefault<Car>(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            Car car;
            car = _cars.SingleOrDefault<Car>(c => c.Id == id);
            return car;
        }

        public void Update(Car car)
        {
            Car carToUpdate;
            carToUpdate = _cars.SingleOrDefault<Car>(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
