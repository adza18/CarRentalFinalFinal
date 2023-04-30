using CarRentalSystem.Core.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Application.DTOs
{
    public class ProfileDTO
    {
        public DocumentType DocumentType { get; set; }

        public string DocumentName { get; set; }
        public string ExistingDocumentName { get; set; }

        public IFormFile DocumentUrl { get; set; }
        public string PhoneNumber { get; set; }


    }
}
