using GeneralService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GeneralService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<City> Get()
        {
            return new List<City>()
            {
                new City(){ ID = 1, Name = "Abbotabad", CreatedBy = "rizwan", CreatedOn = DateTime.Now },
                new City(){ ID = 2, Name = "Balakot", CreatedBy = "rizwan", CreatedOn = DateTime.Now },
                new City(){ ID = 3, Name = "DG Khan", CreatedBy = "rizwan", CreatedOn = DateTime.Now },
                new City(){ ID = 4, Name = "Jhelum", CreatedBy = "rizwan", CreatedOn = DateTime.Now },
                new City(){ ID = 5, Name = "Haiderabad", CreatedBy = "rizwan", CreatedOn = DateTime.Now },
                new City(){ ID = 6, Name = "Lahore", CreatedBy = "rizwan", CreatedOn = DateTime.Now }
            };
        }
    }
}
