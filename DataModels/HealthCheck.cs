using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeDataBaseCodeFirst.DataModels
{
    class HealthCheck
    {
        [Key]
        public Guid Id { get; set; }
        public int HealthCheckNumber { get; set; }
        public DateTime NextHealthCheckDate { get; set; }
        public string Result { get; set; }
        public string Comment { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
