﻿using CarRentalSystem.Core.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Core.Shared
{
    public class Users : IdentityUser { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Department { get; set; }
        public StaffRole? JobTitle { get; set; }
    }
}
