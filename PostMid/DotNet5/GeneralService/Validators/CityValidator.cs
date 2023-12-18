using GeneralService.Models;
using System;

namespace GeneralService.Validators
{
    public class CityValidator
    {
        public bool ValidateOrThrow(City city)
        {
            if (city == null)
            {
                throw new Exception("Value of city cannot be NULL");
            }

            if (string.IsNullOrWhiteSpace(city.Name))
            {
                throw new Exception("Name of city cannot be NULL");
            }

            return true;
        }
    }
}
