using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataBaseCodeFirst.DataModels
{
    public class Context : DbContext
    {
        DbSet<Employee> Employees { get; set; }
        DbSet<Child> Children { get; set; }
        DbSet<AccessPermission> AccessPermissions { get; set; }
        DbSet<Department> Department { get; set; }
        DbSet<HeadOffice> HeadOffice { get; set; }
        DbSet<HealthCheck> HealthInspection { get; set; }
        DbSet<Hints> Hints { get; set; }
        DbSet<JobTitle> JobTitle { get; set; }
        DbSet<ProductsForLoan> ProductsForLoan { get; set; }
        DbSet<Requests> Requests { get; set; }
        DbSet<SickLeave> SickLeave { get; set; }
        DbSet<Vacations> Vacations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=CodeFirstEmployeeDB;Trusted_Connection=True;");
        }
    }
}
