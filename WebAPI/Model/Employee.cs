﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI.Model
{
    public partial class Employee
    {
        public Employee()
        {
            Dependents = new HashSet<Dependent>();
        }

        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeSSN { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsTerminated { get; set; }

        public virtual ICollection<Dependent> Dependents { get; set; }
    }
}
