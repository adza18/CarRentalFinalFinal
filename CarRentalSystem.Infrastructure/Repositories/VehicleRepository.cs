using CarRentalSystem.Application.Interfaces;
using CarRentalSystem.Core.Entities;
using CarRentalSystem.Infrastructure.Persistence;
using CarRentalSystem.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Infrastructure.Repositories
{
    public class VehicleRepository: Repository<Vehicle>, IVehicle
    {
        private readonly ApplicationDbContext _context;
        public VehicleRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Guid id)
        {
            var v = _context.Vehicle.Find(id);
            v.IsAvailable = false;



        }

        public void UpdateCancellation(Guid id)
        {
            var v = _context.Vehicle.Find(id);
            v.IsAvailable = true;
        }
    }
}

