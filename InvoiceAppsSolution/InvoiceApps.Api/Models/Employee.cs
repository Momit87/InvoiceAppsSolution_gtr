// InvoiceApps.Api/Models/Employee.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceApps.Api.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required, MaxLength(150)]
        public string FirstName { get; set; } = null!;

        [MaxLength(150)]
        public string? LastName { get; set; }

        [EmailAddress, MaxLength(256)]
        public string? Email { get; set; }

        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }

        public int? DesignationId { get; set; }
        public Designation? Designation { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Salary { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
