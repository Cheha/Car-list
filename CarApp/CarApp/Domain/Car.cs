using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarApp.Domain
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public int BodyTypeId { get; set; }
        public BodyType BodyType { get; set; }
    }
}