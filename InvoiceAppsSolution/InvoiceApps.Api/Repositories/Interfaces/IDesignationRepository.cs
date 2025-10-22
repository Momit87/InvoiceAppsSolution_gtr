// InvoiceApps.Api/Repositories/IDesignationRepository.cs
using InvoiceApps.Api.Models;

namespace InvoiceApps.Api.Repositories.Interfaces
{
    public interface IDesignationRepository
    {
        Task AddAsync(Designation ent);
        void Update(Designation ent);
        void Remove(Designation ent);
        Task<Designation?> GetByIdAsync(int id);
        Task<IEnumerable<Designation>> GetAllAsync();
    }
}
