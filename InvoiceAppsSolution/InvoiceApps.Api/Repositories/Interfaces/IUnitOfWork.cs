// InvoiceApps.Api/Repositories/IUnitOfWork.cs
using Microsoft.EntityFrameworkCore.Storage;
using InvoiceApps.Api.Models;

namespace InvoiceApps.Api.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IDepartmentRepository Departments { get; }
        IEmployeeRepository Employees { get; }
        IDesignationRepository Designations { get; }
        Task<int> CompleteAsync();
    }
}
