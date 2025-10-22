using InvoiceApps.Api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InvoiceApps.Api.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { }

        public DbSet<Department> Departments { get; set; } = null!;
        public DbSet<Designation> Designations { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<FileRecord> FileRecords { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Department>(e =>
            {
                e.Property(x => x.Name).IsRequired().HasMaxLength(200);
                e.Property(x => x.Description).HasMaxLength(500);
                e.HasMany(d => d.Employees).WithOne(e => e.Department).HasForeignKey(e => e.DepartmentId).OnDelete(DeleteBehavior.SetNull);
            });

            builder.Entity<Designation>(e =>
            {
                e.Property(x => x.Title).IsRequired().HasMaxLength(200);
                e.Property(x => x.Description).HasMaxLength(500);
                e.HasMany(d => d.Employees).WithOne(e => e.Designation).HasForeignKey(e => e.DesignationId).OnDelete(DeleteBehavior.SetNull);
            });

            builder.Entity<Employee>(e =>
            {
                e.Property(x => x.FirstName).IsRequired().HasMaxLength(150);
                e.Property(x => x.LastName).HasMaxLength(150);
                e.Property(x => x.Email).HasMaxLength(256);
                e.Property(x => x.Salary).HasColumnType("decimal(18,2)");
            });

            builder.Entity<FileRecord>(e =>
            {
                e.Property(x => x.FileName).HasMaxLength(250).IsRequired();
                e.Property(x => x.FilePath).HasMaxLength(1000).IsRequired();
                e.Property(x => x.ContentType).HasMaxLength(150).IsRequired();
            });
        }
    }
}
