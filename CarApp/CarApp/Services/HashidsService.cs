﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HashidsNet;

namespace CarApp.Services
{
    public class HashidsService : IHashidsService
    {
        private readonly Hashids _hashids;
        private readonly string salt = "This is spaartaaaaa";
        private readonly int num = 6; 

        public HashidsService()
        {
            _hashids = new Hashids(salt: salt, minHashLength: num);
        }

        public int Decode(string cachedId)
        {
            return _hashids.Decode(cachedId)[0];
        }

        public string Encode(int id)
        {
            return _hashids.Encode(id);
        }
    }
}