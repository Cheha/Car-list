using System;
using System.Collections.Generic;
using CarApp.Domain;

namespace CarApp.Services
{
    public interface ICarService
    {
        List<Car> GetAllCars();
        void AddCar(Car car);
        List<Brand> GetAllBrands();
        List<BodyType> GetAllBodyTypes();
    }
}
