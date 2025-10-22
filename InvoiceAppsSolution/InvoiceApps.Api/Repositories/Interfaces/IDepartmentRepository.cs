// InvoiceApps.Api/Repositories/IDepartmentRepository.cs
using InvoiceApps.Api.Models;

namespace InvoiceApps.Api.Repositories.Interfaces
{
    public interface IDepartmentRepository
    {
        Task AddAsync(Department dept);
        void Update(Department dept);
        void Remove(Department dept);
        Task<Department?> GetByIdAsync(int id);
        Task<IEnumerable<Department>> GetAllAsync();
    }
}
