using CarRentalSystem.Core.Enums;
using CarRentalSystem.Core.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Core.Entities
{
    public class Rental
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime RequestedDate { get; set; } = DateTime.Now;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool isReturned { get; set; } = false;
        public bool isCancelled { get; set; } = false;
        public RentalStatus RentalStatus { get; set; } = RentalStatus.ApprovalPending;


        public DateTime ReturnedDate { get; set; }
        public bool IsApproved { get; set; }
        public int Fee { get; set; }
        public Guid CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        public string? UserId { get; set; } 

        [ForeignKey("UserId")]
        public virtual Users? User { get; set; }

        public Guid VehicleId { get; set; }

        [ForeignKey("VehicleId")]
        public virtual Vehicle Vehicle { get; set; }





    }
}
