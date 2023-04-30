using CarRentalSystem.Application.DTOs;
using CarRentalSystem.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Application.Common.Services
{
    public interface IUserService
    {

     
        Task<IEnumerable<Users>> GetUserDetails();
        string GetUserName(string email);

        string GetDocument(string id);

        Task<Users> GetUser(string Id);

        void LockUser(string Id);

        void UnlockUser(string Id);


    }
}
