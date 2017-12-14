using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarApp.Domain;

namespace CarApp.Data.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private AppDbContext _context;

        public BrandRepository()
        {
            _context = new AppDbContext();
        }

        public List<Brand> Get()
        {
            return _context.Brands.ToList();
        }
    }
}