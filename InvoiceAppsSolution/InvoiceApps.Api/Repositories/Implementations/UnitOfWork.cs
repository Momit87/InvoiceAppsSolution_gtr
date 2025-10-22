// InvoiceApps.Api/Repositories/UnitOfWork.cs
using InvoiceApps.Api.Data;
using InvoiceApps.Api.Repositories.Interfaces;

namespace InvoiceApps.Api.Repositories.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _ctx;
        private IDepartmentRepository? _departments;
        private IEmployeeRepository? _employees;
        private IDesignationRepository? _designations;

        public UnitOfWork(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        public IDepartmentRepository Departments => _departments ??= new DepartmentRepository(_ctx);
        public IEmployeeRepository Employees => _employees ??= new EmployeeRepository(_ctx);
        public IDesignationRepository Designations => _designations ??= new DesignationRepository(_ctx);

        public async Task<int> CompleteAsync() => await _ctx.SaveChangesAsync();

        public void Dispose() => _ctx.Dispose();
    }
}
