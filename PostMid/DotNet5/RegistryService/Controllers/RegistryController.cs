using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistryService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RegistryService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistryController : ControllerBase
    {
        private static List<ApiInfoDTO> _apis = new List<ApiInfoDTO>();

        [HttpPost("Register")]
        public bool Register(ApiInfoDTO apiInfo)
        {
            if (apiInfo != null && !string.IsNullOrWhiteSpace(apiInfo.ServiceName) && !string.IsNullOrWhiteSpace(apiInfo.ControllerName) && !string.IsNullOrWhiteSpace(apiInfo.Url))
            {
                throw new Exception("ServiceName, ControllerName or Url cannot be NULL");
            }

            if (_apis.Any())
            {
                if(_apis.Exists(x => x.ServiceName == apiInfo.ServiceName))
                {
                    throw new Exception("Unable to register. Service already exists in the system.");
                }

                apiInfo.ID = _apis.Max(x => x.ID) + 1;
            }
            else
            {
                apiInfo.ID = 1;
            }

            _apis.Add(apiInfo);
            return true;
        }

        [HttpGet]
        public ApiInfoDTO Get(string serviceName)
        {
            return _apis.Find(x => x.ServiceName == serviceName);
        }
    }
}
