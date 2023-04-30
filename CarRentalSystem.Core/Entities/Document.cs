using CarRentalSystem.Core.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Core.Entities
{
    public class Document
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int DocumentNumber { get; set; }
        public DocumentType DocumentType { get; set; }
        public string? DocumentName { get; set; }
        public string? DocumentPhoto { get; set; }

        [NotMapped]
        public IFormFile? DocumentUrl { get; set; }
        public Guid CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}
