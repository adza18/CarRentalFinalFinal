using CarRentalSystem.Core.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Core.Entities
{
    public class Staff
    {
        public Guid Id { get; set; } = new Guid();
        public string Department { get; set; }
        public string JobTitle { get; set; }


        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public Users AppUser { get; set; }

    }
}
