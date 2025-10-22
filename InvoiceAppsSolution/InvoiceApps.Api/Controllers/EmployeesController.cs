// InvoiceApps.Api/Controllers/EmployeesController.cs
using Microsoft.AspNetCore.Mvc;
using InvoiceApps.Api.Models;
using InvoiceApps.Api.Repositories;
using InvoiceApps.Api.Repositories.Interfaces; // added
using InvoiceApps.Api.Services;

namespace InvoiceApps.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly DapperReadService _dapper;

        public EmployeesController(IUnitOfWork uow, DapperReadService dapper)
        {
            _uow = uow;
            _dapper = dapper;
        }

        // GET /api/employees
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var list = await _dapper.GetEmployeesViaStoredProcAsync();
            return Ok(list);
        }

        // POST /api/employees
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Employee emp)
        {
            await _uow.Employees.AddAsync(emp);
            await _uow.CompleteAsync();
            return CreatedAtAction(nameof(GetAll), new { id = emp.Id }, emp);
        }
    }
}
