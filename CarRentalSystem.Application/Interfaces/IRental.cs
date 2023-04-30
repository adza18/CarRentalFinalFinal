using CarRentalSystem.Application.Common;
using CarRentalSystem.Core.Entities;
using CarRentalSystem.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Application.Interfaces
{
    public interface IRental: IRepository<Rental>
    {
        void UpdateStatus(Guid id, RentalStatus status);
        void Approve(Guid id, RentalStatus status, string id2);

    }
}
