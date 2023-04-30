using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Application.DTOs
{
    public class VehicleDTO
    {
        public string? VehicleModel { get; set; }
        public string? Color { get; set; }
        public string? PlateNumber { get; set; }
        public int PricePerDay { get; set; }
        public string? VehicleImage { get; set; }


        [NotMapped]
        public IFormFile? PhotoUrl { get; set; }
    }
}
