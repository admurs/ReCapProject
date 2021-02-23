using Business.Concrete;
using System;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var car in carManager.GetCarsByColorId(1))
            //{
            //    Console.WriteLine(car.Description);
            //}
            carManager.Add(new Car
            {
                Id = 11,BrandId = 1,Description = "Adem",ColorId = 2,DailyPrice = -10,ModelYear = "2018"
            });



        }
    }
}
