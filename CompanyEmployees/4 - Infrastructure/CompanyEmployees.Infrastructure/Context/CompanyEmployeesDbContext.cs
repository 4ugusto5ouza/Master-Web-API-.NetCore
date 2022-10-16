using CompanyEmployees.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CompanyEmployees.Infrastructure.Context
{
    public class CompanyEmployeesDbContext : DbContext
    {
        public CompanyEmployeesDbContext(DbContextOptions options)
            : base(options)
        {
        }

        DbSet<Company>? Companies { get; set; }
        DbSet<Employee>? Employees { get; set; }
    }
}
