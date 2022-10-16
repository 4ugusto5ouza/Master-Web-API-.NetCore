using CompanyEmployees.Domain.Entities;
using CompanyEmployees.Domain.Interfaces.Repositories;
using CompanyEmployees.Infrastructure.Context;
using CompanyEmployees.Infrastructure.RepositoryBase;

namespace CompanyEmployees.Infrastructure.Repositories
{
    public class EmployeeRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public EmployeeRepository(CompanyEmployeesDbContext companyEmployeesDbContext)
            : base(companyEmployeesDbContext)
        {
        }
    }
}
