using CompanyEmployees.Domain.Interfaces.Repositories;

namespace CompanyEmployees.Domain.Interfaces
{
    public interface IRepositoryManager
    {
        ICompanyRepository companyRepository { get; }
        IEmployeeRepository employeeRepository { get; }

        void Save();
    }
}
