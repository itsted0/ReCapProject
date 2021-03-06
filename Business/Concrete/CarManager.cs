﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;

        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }

        public List<Car> GetAll()
        {
            return _cardal.GetAll();
        }

        /*
        public Car GetById(int id)
        {
            return _cardal.GetById(id);
        }
        */
        public void Add(Car car)
        {   
            if(car.DailyPrice > 0 && car.Name.Length > 2)
            {
                _cardal.Add(car);
            }
        }

        public void Update(Car car)
        {
            _cardal.Update(car);
        }

        public void Delete(Car car)
        {
            _cardal.Delete(car);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _cardal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _cardal.GetAll(p => p.ColorId == id);
        }
    }
}
