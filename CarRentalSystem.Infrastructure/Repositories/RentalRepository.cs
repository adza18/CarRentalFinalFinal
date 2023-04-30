using CarRentalSystem.Application.Common;
using CarRentalSystem.Application.Interfaces;
using CarRentalSystem.Core.Entities;
using CarRentalSystem.Core.Enums;
using CarRentalSystem.Infrastructure.Persistence;
using CarRentalSystem.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Infrastructure.Repositories
{
    public class RentalRepository: Repository<Rental>,IRental
    {
        private readonly ApplicationDbContext _context;
        public RentalRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }


    

        public void Approve(Guid id1, RentalStatus status, string id2)
        {
            var v = _context.Rental.Find(id1);
         
            if (RentalStatus.OnRent == status)
            {
                v.IsApproved = true;

            }
            v.RentalStatus = status;
            v.UserId = id2;
        }

        public void UpdateStatus(Guid id, RentalStatus status)
        {
            var v = _context.Rental.Find(id);
            if (status == RentalStatus.Cancelled)
            {
                v.isCancelled = true;

            }
            if (RentalStatus.OnRent == status)
            {
                v.IsApproved = true;

            }
            v.RentalStatus = status;
        }
    }
}
