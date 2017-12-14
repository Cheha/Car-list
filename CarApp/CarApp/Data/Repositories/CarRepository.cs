using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarApp.Domain;

namespace CarApp.Data.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _context;

        public CarRepository()
        {
            _context = new AppDbContext();
        }

        public void Add(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
        }

        public List<Car> Get()
        {
            return _context.Cars
                .Include("BodyType")
                .Include("Brand")
                .ToList();
        }

        public Car Get(int id)
        {
            return _context.Cars.Find(id);
        }
    }
}