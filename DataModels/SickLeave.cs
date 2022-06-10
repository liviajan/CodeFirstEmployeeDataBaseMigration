using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeDataBaseCodeFirst.DataModels
{
    class SickLeave
    {
        [Key]
        public Guid Id { get; set; }
        public int SickLeaveNumber { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Comment { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
