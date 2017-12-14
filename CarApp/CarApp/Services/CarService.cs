using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarApp.Domain;
using CarApp.Data.Repositories;

namespace CarApp.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IBrandRepository _brandRepository;
        private readonly IBodyTypeRepository _bodyTypeRepository;

        public CarService()
        {
            _carRepository = new CarRepository();
            _bodyTypeRepository = new BodyTypeRepository();
            _brandRepository = new BrandRepository();
        }

        public void AddCar(Car car)
        {
            _carRepository.Add(car);
        }

        public List<BodyType> GetAllBodyTypes()
        {
            return _bodyTypeRepository.Get();
        }

        public List<Brand> GetAllBrands()
        {
            return _brandRepository.Get();
        }

        public List<Car> GetAllCars()
        {
            return _carRepository.Get();
        }
    }
}