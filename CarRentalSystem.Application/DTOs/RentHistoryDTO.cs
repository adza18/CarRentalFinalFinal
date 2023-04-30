using CarRentalSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Application.DTOs
{
    public class RentHistoryDTO
    {
        public List<Rental> Rental { get; set; }
        public Vehicle Vehicle { get; set; }

    }
}
