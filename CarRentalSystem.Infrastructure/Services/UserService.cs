using CarRentalSystem.Application.Common;
using CarRentalSystem.Application.Common.Services;
using CarRentalSystem.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public  string GetDocument(string id)
        {

            var customer =  _unitOfWork.Customer.GetFirstOrDefault(x=> x.UserId == id);


            var document =  _unitOfWork.Document.GetFirstOrDefault(x => x.CustomerId == customer.Id);
            if(document != null)
            {
                return document.DocumentName;

            }
            else
            {
                return "";
            }
        }

        public Task<Users> GetUser(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Users>> GetUserDetails()
        {
            throw new NotImplementedException();
        }

        public string GetUserName(string email)
        {
            throw new NotImplementedException();
        }

        public void LockUser(string Id)
        {
            throw new NotImplementedException();
        }

        public void UnlockUser(string Id)
        {
            throw new NotImplementedException();
        }
    }
}
