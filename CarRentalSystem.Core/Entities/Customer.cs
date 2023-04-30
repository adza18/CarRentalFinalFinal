using CarRentalSystem.Core.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Core.Entities
{
    public class Customer
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public int LicenseNumber { get; set; }
        public bool isApproved { get; set; } = false;
        public bool isActive { get; set; } = true;
        public bool isRegular { get; set; }
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public Users AppUser { get; set; }








    }
}
