using CompanyEmployees.Domain.Entities;
using System.Collections.Generic;

namespace CompanyEmployees.Service.Interfaces
{
    public interface ICompanyService
    {
        IEnumerable<Company> GetAllCompanies(bool trackChanges);
    }
}
