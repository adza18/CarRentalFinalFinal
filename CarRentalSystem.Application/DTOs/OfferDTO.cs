using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Application.DTOs
{
    public class OfferDTO
    {
        public DateTime ValidityDate { get; set; }
        public string? OfferMessage { get; set; }
        public Guid VehicleId { get; set; }


    }
}
