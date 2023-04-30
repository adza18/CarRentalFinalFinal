using CarRentalSystem.Application.Common;
using CarRentalSystem.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Application.Interfaces
{
    public interface IUser : IRepository<Users>
    {
    }
}
