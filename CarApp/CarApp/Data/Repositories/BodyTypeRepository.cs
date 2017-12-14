using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarApp.Domain;

namespace CarApp.Data.Repositories
{
    public class BodyTypeRepository : IBodyTypeRepository
    {
        private readonly AppDbContext _context;

        public BodyTypeRepository()
        {
            _context = new AppDbContext();
        }

        public List<BodyType> Get()
        {
            return _context.BodyTypes.ToList();
        }
    }
}