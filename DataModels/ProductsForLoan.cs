﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeDataBaseCodeFirst.DataModels
{
    class ProductsForLoan
    {
        [Key]
        public Guid Id { get; set; }
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime Returndate { get; set; }
        public string Comment { get; set; }


        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
