using CarRentalSystem.Application.Common;
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
    public class DamageRepository: Repository<Damages>, IDamages
    {
        private readonly ApplicationDbContext _context;
        public DamageRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
