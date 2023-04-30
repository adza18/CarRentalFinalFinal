using CarRentalSystem.Application.Common;
using CarRentalSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Application.Interfaces
{
    public interface IVehicle : IRepository<Vehicle>
    {
        void Update(Guid id);
        void UpdateCancellation(Guid id);

    }
}
