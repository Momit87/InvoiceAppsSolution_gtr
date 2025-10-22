// InvoiceApps.Api/Models/Designation.cs
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace InvoiceApps.Api.Models
{
    public class Designation
    {
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string Title { get; set; } = null!;

        [MaxLength(500)]
        public string? Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<Employee>? Employees { get; set; }
    }
}
