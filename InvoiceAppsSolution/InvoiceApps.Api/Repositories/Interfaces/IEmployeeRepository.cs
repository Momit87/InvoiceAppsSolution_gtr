// InvoiceApps.Api/Repositories/IEmployeeRepository.cs
using InvoiceApps.Api.Models;

namespace InvoiceApps.Api.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Task AddAsync(Employee ent);
        void Update(Employee ent);
        void Remove(Employee ent);
        Task<Employee?> GetByIdAsync(int id);
        Task<IEnumerable<Employee>> GetAllAsync();
    }
}
