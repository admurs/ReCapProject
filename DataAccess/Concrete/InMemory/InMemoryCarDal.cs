using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{BrandId = 1,ColorId = 1,DailyPrice = 50,Description = "Nissan 4x4",Id = 1,ModelYear = "2021"},
                new Car{BrandId = 1,ColorId = 2,DailyPrice = 100,Description = "Nissan Otomatik Sedan",Id = 2,ModelYear = "2020"},
                new Car{BrandId = 2,ColorId = 3,DailyPrice = 80,Description = "Fiat Benzinli Hatchback",Id = 3,ModelYear = "2019"},
                new Car{BrandId = 2,ColorId = 5,DailyPrice = 150,Description = "Fiat Dizel MPV",Id = 4,ModelYear = "2015"},
                new Car{BrandId = 2,ColorId = 8,DailyPrice = 200,Description = "Fiat Hybrit SUV",Id = 5,ModelYear = "2021"},
                new Car{BrandId = 3,ColorId = 7,DailyPrice = 180,Description = "Peugeot 508 Sedan",Id = 6,ModelYear = "2018"},
                new Car{BrandId = 4,ColorId = 1,DailyPrice = 190,Description = "Citroen C5 SUV",Id = 7,ModelYear = "2020"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
