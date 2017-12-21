using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarApp.Domain;
using CarApp.Data.Repositories;
using CarApp.Models;

namespace CarApp.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IBrandRepository _brandRepository;
        private readonly IBodyTypeRepository _bodyTypeRepository;
        private readonly IHashidsService _hashidsService;

        public CarService()
        {
            _carRepository = new CarRepository();
            _bodyTypeRepository = new BodyTypeRepository();
            _brandRepository = new BrandRepository();
            _hashidsService = new HashidsService();
        }

        public void AddCar(CarBindingModel model)
        {
            var car = new Car
            {
                Model = model.Model,
                BrandId = _hashidsService.Decode(model.BrandNumber),
                BodyTypeId = _hashidsService.Decode(model.BodyTypeNumber)
            };
            _carRepository.Add(car);
        }

        public List<BodyTypeViewModel> GetAllBodyTypes()
        {
            var bodyTypes = _bodyTypeRepository.Get();
            return bodyTypes.Select(_ => new BodyTypeViewModel {
                BodyTypeNumber = _hashidsService.Encode(_.Id),
                BodyTypeName = _.Name
            }).ToList();
        }

        public List<BrandViewModel> GetAllBrands()
        {
            var brands = _brandRepository.Get();
            return brands.Select(_ => new BrandViewModel {
                BrandNumber = _hashidsService.Encode(_.Id),
                BrandName = _.Name
            }).ToList();
        }

        public List<CarViewModel> GetAllCars()
        {
            var cars = _carRepository.Get();
            return cars.Select(_ => new CarViewModel
            {
                CarNumber = _hashidsService.Encode(_.Id),
                Model = _.Model,
                BodyType = _.BodyType.Name,
                BrandName = _.Brand.Name
            }).ToList();
        }

        public CarViewModel GetCar(string carNumber)
        {
            var carId = _hashidsService.Decode(carNumber);
            var car = _carRepository.Get(carId);
            return new CarViewModel
            {
                BodyType = car.BodyType.Name,
                BrandName = car.Brand.Name,
                Model = car.Model,
                CarNumber = carNumber
            };
        }
    }
}