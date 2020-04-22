using Microsoft.AspNetCore.Mvc;
using Przykladowe_kolokwium_APBD_1.DTOs.Request;

namespace Przykladowe_kolokwium_APBD_1.Services
{
    public interface IServiceDb
    {
        public IActionResult getAnimals(string columnName);
        public IActionResult enrollStudent(AnimalRequest animalRequest);
    }
}