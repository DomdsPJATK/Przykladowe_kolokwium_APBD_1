using System;
using Microsoft.AspNetCore.Mvc;
using Przykladowe_kolokwium_APBD_1.DTOs.Request;
using Przykladowe_kolokwium_APBD_1.Services;

namespace Przykladowe_kolokwium_APBD_1.Controllers
{
    [ApiController]
    [Route("api/animals")]
    public class ClinicController : ControllerBase
    {
        private readonly IServiceDb _serviceDb;
        
        public ClinicController(IServiceDb serviceDb)
        {
            _serviceDb = serviceDb;
        }
        
        [HttpGet]
        public IActionResult getAnimals(string sortBy)
        {
            Console.WriteLine("Lol");
            return _serviceDb.getAnimals(sortBy);
        }

        [HttpPost]
        public IActionResult enrollAnimal(AnimalRequest request)
        {
            return _serviceDb.enrollStudent(request);
        }
        
    }
}