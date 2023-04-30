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
    public class Invoice : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public int MyProperty { get; set; }
        public InvoiceType InvoiceType { get; set; }

        public Guid? DamageId { get; set; }

        [ForeignKey("DamageId")]
        public Damages? Damage { get; set; }
        public Guid? RentalId { get; set; }

        [ForeignKey("RentalId")]
        public Rental? VehicleRental { get; set; }


    }
}
