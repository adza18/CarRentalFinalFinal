using CarRentalSystem.Application.Common;
using CarRentalSystem.Application.Interfaces;
using CarRentalSystem.Infrastructure.Persistence;
using CarRentalSystem.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Infrastructure.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Vehicle = new VehicleRepository(_dbContext);
            Customer = new CustomerRepository(_dbContext);
            User = new UserRepository(_dbContext);
            Staff = new StaffRepository(_dbContext);
            Document = new DocumentRepository(_dbContext);
            Rental = new RentalRepository(_dbContext);
            Damage = new DamageRepository(_dbContext);

        }

        public IVehicle Vehicle { get; set; }
        public ICustomer Customer { get; set; }
        public IStaff Staff { get; set; }
        public IUser User { get; set; }
        public IDocument Document { get; set; }
        public IRental Rental { get; set; }
        public IDamages Damage { get; set; }




        //public IDocument Document { get; set; }




        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
