using CarRentalSystem.Core.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Core.Entities
{
    public class Offer : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string OfferDescription { get; set; }
        public DateTime ValidityDate { get; set; }
        public Guid VehicleId { get; set; }

        [ForeignKey("VehicleId")]
        public virtual Vehicle Vehicle { get; set; }


    }
}
