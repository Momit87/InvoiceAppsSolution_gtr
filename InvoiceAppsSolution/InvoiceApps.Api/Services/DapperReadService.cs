using Dapper;
using InvoiceApps.Api.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace InvoiceApps.Api.Services
{
    public class DapperReadService
    {
        private readonly string _conn;

        public DapperReadService(IConfiguration config)
        {
            _conn = config.GetConnectionString("DefaultConnection") 
                ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        }

        public async Task<IEnumerable<Department>> GetDepartmentsViaStoredProcAsync()
        {
            await using var connection = new SqlConnection(_conn);
            await connection.OpenAsync();

            var result = await connection.QueryAsync<Department>(
                "GetDepartments",
                commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<IEnumerable<dynamic>> GetEmployeesViaStoredProcAsync()
        {
            await using var connection = new SqlConnection(_conn);
            await connection.OpenAsync();

            var result = await connection.QueryAsync(
                "GetEmployees",
                commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
