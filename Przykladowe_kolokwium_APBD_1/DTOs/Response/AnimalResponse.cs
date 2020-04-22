using System;

namespace Przykladowe_kolokwium_APBD_1.DTOs.Response
{
    public class AnimalResponse
    {
        public string Name { get; set; }
        public string AnimalType { get; set; }
        public DateTime Date { get; set; }
        public string LastNameOfOwner { get; set; }
    }
}