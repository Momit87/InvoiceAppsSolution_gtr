// InvoiceApps.Api/Controllers/DepartmentsController.cs
using Microsoft.AspNetCore.Mvc;
using InvoiceApps.Api.Models;
using InvoiceApps.Api.Repositories;
using InvoiceApps.Api.Repositories.Interfaces; // added
using InvoiceApps.Api.Services;

namespace InvoiceApps.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentsController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly DapperReadService _dapper;

        public DepartmentsController(IUnitOfWork uow, DapperReadService dapper)
        {
            _uow = uow;
            _dapper = dapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var deps = await _dapper.GetDepartmentsViaStoredProcAsync(); // demonstrates Dapper stored proc usage
            return Ok(deps);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Department dept)
        {
            await _uow.Departments.AddAsync(dept);
            await _uow.CompleteAsync();
            return CreatedAtAction(nameof(GetAll), new { id = dept.Id }, dept);
        }
    }
}
