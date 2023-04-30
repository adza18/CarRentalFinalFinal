using CarRentalSystem.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Application.Common.Services
{
    public interface IPayment
    {
        Task<PaymentResponseDTO> Payment(string payAmount, string payToken);
    }
}
