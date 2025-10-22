// InvoiceApps.Api/Repositories/DepartmentRepository.cs
using InvoiceApps.Api.Data;
using InvoiceApps.Api.Models;
using InvoiceApps.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InvoiceApps.Api.Repositories.Implementations
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _ctx;
        public DepartmentRepository(AppDbContext ctx) => _ctx = ctx;

        public async Task AddAsync(Department dept) => await _ctx.Departments.AddAsync(dept);

        public async Task<IEnumerable<Department>> GetAllAsync() => await _ctx.Departments.AsNoTracking().ToListAsync();

        public async Task<Department?> GetByIdAsync(int id) => await _ctx.Departments.FindAsync(id);

        public void Remove(Department dept) => _ctx.Departments.Remove(dept);

        public void Update(Department dept) => _ctx.Departments.Update(dept);
    }
}
