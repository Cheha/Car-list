﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarApp.Domain;

namespace CarApp.Data.Repositories
{
    public interface IBodyTypeRepository
    {
        List<BodyType> Get();
    }
}
