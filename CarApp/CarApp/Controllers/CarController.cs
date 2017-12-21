using CarApp.Domain;
using CarApp.Models;
using CarApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarApp.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;

        public CarController()
        {
            _carService = new CarService();
        }
        
        public ActionResult Index()
        {
            var cars = _carService.GetAllCars();
            return View(cars);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CarBindingModel car)
        {
            _carService.AddCar(car);
            return RedirectToAction("Index");
        }

        public ActionResult Details(string carNumber)
        {
            var carViewModel = _carService.GetCar(carNumber);
            return View(carViewModel);
        }
    }
}