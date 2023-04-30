using CarRentalSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Application.DTOs
{
    public class ReturnVehicleDTO
    {
        public Rental Rental { get; set; }
        public Vehicle Vehicle { get; set; }
        public int NoOfDays { get; set; }
        public int Total { get; set; }



    }
}
