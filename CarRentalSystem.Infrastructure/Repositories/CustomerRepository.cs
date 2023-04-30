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
    public class CustomerRepository : Repository<Customer>, ICustomer
    {
        private readonly ApplicationDbContext _context;
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public Guid GetCustomerId(string id)
        {
            var customer = _context.Customer.FirstOrDefault(x => x.UserId == id);
            return customer.Id;
        }
    }
}
