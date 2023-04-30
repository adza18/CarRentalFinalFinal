using CarRentalSystem.Core.Entities;
using CarRentalSystem.Core.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Application.DTOs
{
    public class RentVehicleDTO
    {
       
        public Vehicle Vehicle { get; set; }
        public Guid Vehicleid { get; set; }

        public Guid CustomerId { get; set; }
        public DateTime RequestedDate { get; set; }

        public bool DocumentExists { get; set; } = false;

        [NotMapped]
        public IFormFile? DocumentUrl { get; set; }
        public DocumentType DocumentType { get; set; }
        public string DocumentName { get; set; }



    }
}
