﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataBaseCodeFirst.DataModels
{
    class Child
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public string PersonalIdCode { get; set; }
        public string Comment { get; set; }


        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
