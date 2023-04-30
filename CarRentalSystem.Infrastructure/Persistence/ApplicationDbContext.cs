using CarRentalSystem.Core.Entities;
using CarRentalSystem.Core.Shared;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Infrastructure.Persistence
{

    public class ApplicationDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Users> User { get; set; }
        public DbSet<Customer> Customer { get; set; }

        public DbSet<Staff> Staff { get; set; }
        public DbSet<Rental> Rental { get; set; }
        public DbSet<Damages> Damage { get; set; }



        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Core.Entities.Document> Document { get; set; }













    }
}
