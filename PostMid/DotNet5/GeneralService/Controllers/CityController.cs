using GeneralService.Models;
using GeneralService.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;

namespace GeneralService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private static List<City> _cities = new List<City>()
            {
                new City(){ ID = 1, Name = "Abbotabad", CreatedBy = "rizwan", CreatedOn = new DateTime(2000, 12, 10, 14, 15, 16)},
                new City(){ ID = 2, Name = "Balakot", CreatedBy = "rizwan", CreatedOn = new DateTime(2000, 12, 11, 13, 15, 16)},
                new City(){ ID = 3, Name = "DG Khan", CreatedBy = "rizwan", CreatedOn = new DateTime(2000, 12, 12, 15, 15, 16)},
                new City(){ ID = 4, Name = "Jhelum", CreatedBy = "rizwan", CreatedOn = new DateTime(2000, 12, 13, 16, 15, 16)},
                new City(){ ID = 5, Name = "Haiderabad", CreatedBy = "rizwan", CreatedOn = new DateTime(2000, 12, 17, 14, 15, 16)},
                new City(){ ID = 6, Name = "Lahore", CreatedBy = "rizwan", CreatedOn = new DateTime(2000, 12, 12, 18, 15, 16)}
            };

        [HttpGet]
        public IEnumerable<City> Get()
        {
            return _cities;
        }

        [HttpGet, Route("{id}")]
        public City Get(long id)
        {
            if (id <= 0)
            {
                throw new Exception("Invalid identifier");
            }

            var city = _cities.Find(x => x.ID == id);

            if (city == null)
            {
                throw new Exception($"No record found against given identifier {id}");
            }

            return city;
        }

        [HttpPost]
        public City Save(City city)
        {
            if (city == null)
            {
                throw new Exception("No content received");
            }

            var validator = new CityValidator();
            validator.ValidateOrThrow(city);

            city.ID = _cities.Max(x => x.ID) + 1;
            city.CreatedBy = "admin";
            city.CreatedOn = DateTime.UtcNow;
            _cities.Add(city);

            return city;
        }

        [HttpPut, Route("{id}")]
        public City Update(long id, City city)
        {
            if (city == null)
            {
                throw new Exception("No content received");
            }

            if (id == 0 || city.ID == 0 || id != city.ID)
            {
                throw new Exception("Invalid identitfier");
            }

            var validator = new CityValidator();
            validator.ValidateOrThrow(city);

            var _city = _cities.Find(x => x.ID == id);

            if (_city == null)
            {
                throw new Exception($"No row exists with given identifier#{id}");
            }

            _city.ModifiedBy = "admin";
            _city.ModifiedOn = DateTime.UtcNow;
            _city.Name = city.Name;

            return _city;
        }

        [HttpDelete, Route("{id}")]
        public bool Delete(long id)
        {
            if (id <= 0)
            {
                throw new Exception("Invalid identifier");
            }

            var city = _cities.Find(x => x.ID == id);
            if (city == null)
            {
                throw new Exception($"No row exists with given identifier#{id}");
            }

            return _cities.Remove(city);
        }
    }
}
