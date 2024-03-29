﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Core.Shared
{

    public abstract class BaseEntity
    {
        //possible to ovveride properties
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? DeletionTime { get; set; }

        public bool IsDeleted { get; set; }

        public string CreatedBy { get; set; }

        public int ModifiedBy { get; set; }

        public int DeletedBy { get; set; }

    }
}
