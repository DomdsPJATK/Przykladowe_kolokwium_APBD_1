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
        
        ClinicController(SqlAnimalServiceDb serviceDb)
        {
            _serviceDb = serviceDb;
        }

        [HttpGet("{columnName}")]
        public IActionResult getAnimals(string columnName)
        {
            return _serviceDb.getAnimals(columnName);
        }

        [HttpPost]
        public IActionResult enrollAnimal(AnimalRequest request)
        {
            return _serviceDb.enrollStudent(request);
        }
        
    }
}