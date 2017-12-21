using System;
using System.Collections.Generic;
using CarApp.Domain;
using CarApp.Models;

namespace CarApp.Services
{
    public interface ICarService
    {
        List<CarViewModel> GetAllCars();
        void AddCar(CarBindingModel car);
        List<BrandViewModel> GetAllBrands();
        List<BodyTypeViewModel> GetAllBodyTypes();
        CarViewModel GetCar(string carNumber);
    }
}
