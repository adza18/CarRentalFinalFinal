using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Core.Entities
{
    public class Damages
    {
        public Guid Id { get; set; }
        public string DamageDescription { get; set; }

        public int DamageFee { get; set; }
        public bool IsPaid { get; set; }
        public Guid DamageFiledBy { get; set; }

        [ForeignKey("DamageFiledBy")]
        public virtual Customer Customer { get; set; }
        public Guid VehicleId { get; set; }

        [ForeignKey("VehicleId")]
        public virtual Vehicle Vehicle { get; set; }



    }
}
