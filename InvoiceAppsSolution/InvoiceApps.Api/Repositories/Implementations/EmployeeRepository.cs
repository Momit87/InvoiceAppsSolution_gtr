// InvoiceApps.Api/Repositories/EmployeeRepository.cs
using InvoiceApps.Api.Data;
using InvoiceApps.Api.Models;
using InvoiceApps.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InvoiceApps.Api.Repositories.Implementations
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _ctx;
        public EmployeeRepository(AppDbContext ctx) => _ctx = ctx;

        public async Task AddAsync(Employee ent) => await _ctx.Employees.AddAsync(ent);
        public async Task<Employee?> GetByIdAsync(int id) => await _ctx.Employees.FindAsync(id);
        public async Task<IEnumerable<Employee>> GetAllAsync() =>
            await _ctx.Employees.Include(e => e.Department).Include(e => e.Designation).AsNoTracking().ToListAsync();
        public void Remove(Employee ent) => _ctx.Employees.Remove(ent);
        public void Update(Employee ent) => _ctx.Employees.Update(ent);
    }
}
