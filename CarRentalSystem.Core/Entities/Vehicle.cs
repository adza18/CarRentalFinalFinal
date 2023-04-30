using CarRentalSystem.Core.Shared;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Core.Entities
{
    public class Vehicle : BaseEntity
    {
        public Guid Id { get; set; } = new Guid();
        public string? Model { get; set; }
        public string? Color { get; set; }
        public string? PlateNumber { get; set; }
        public int PricePerDay { get; set; }
        public string? Feature { get; set; }
        public bool IsAvailable { get; set; } = true;
        public string? VehicleImage { get; set; }


        [NotMapped]
        public IFormFile? PhotoUrl { get; set; }


    }
}
