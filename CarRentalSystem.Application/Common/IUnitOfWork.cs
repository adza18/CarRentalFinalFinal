using CarRentalSystem.Application.Interfaces;
using CarRentalSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Application.Common
{
    public interface IUnitOfWork
    {
        IVehicle Vehicle { get; set; }
        ICustomer Customer { get; set; }
        IUser User { get; set; }
        IDocument Document { get; set; }
        IRental Rental { get; set; }
        IDamages Damage { get; set; }
        IOffer Offer { get; set; }





        //IDocument Document { get; set; }
        Task<int> SaveChangesAsync();
    }
}
