using CarRentalSystem.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Application.DTOs
{
    public class StaffRegisterDTO
    {
       

        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public StaffRole JobTitle { get; set; }


        [Required(ErrorMessage = "Password is required")]

        public string? Password { get; set; }
    }
}
