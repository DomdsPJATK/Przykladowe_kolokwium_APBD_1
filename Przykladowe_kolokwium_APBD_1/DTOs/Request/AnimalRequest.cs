using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Przykladowe_kolokwium_APBD_1.DAL;

namespace Przykladowe_kolokwium_APBD_1.DTOs.Request
{
    public class AnimalRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string AnimalType { get; set; }
        [Required]
        [JsonConverter(typeof(CustonDateTimeConverter))]
        public DateTime Date { get; set; }
        [Required]
        public int OwnerId { get; set; }
    }
}