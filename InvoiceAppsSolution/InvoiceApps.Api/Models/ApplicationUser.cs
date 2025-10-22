// InvoiceApps.Api/Models/ApplicationUser.cs
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace InvoiceApps.Api.Models
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(200)]
        public string? FullName { get; set; }
    }
}
