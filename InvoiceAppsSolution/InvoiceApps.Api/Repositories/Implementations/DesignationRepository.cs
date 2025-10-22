// InvoiceApps.Api/Repositories/DesignationRepository.cs
using InvoiceApps.Api.Data;
using InvoiceApps.Api.Models;
using InvoiceApps.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InvoiceApps.Api.Repositories.Implementations
{
    public class DesignationRepository : IDesignationRepository
    {
        private readonly AppDbContext _ctx;
        public DesignationRepository(AppDbContext ctx) => _ctx = ctx;

        public async Task AddAsync(Designation ent) => await _ctx.Designations.AddAsync(ent);
        public async Task<Designation?> GetByIdAsync(int id) => await _ctx.Designations.FindAsync(id);
        public async Task<IEnumerable<Designation>> GetAllAsync() => await _ctx.Designations.AsNoTracking().ToListAsync();
        public void Remove(Designation ent) => _ctx.Designations.Remove(ent);
        public void Update(Designation ent) => _ctx.Designations.Update(ent);
    }
}
