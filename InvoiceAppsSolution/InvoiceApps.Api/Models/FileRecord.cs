// InvoiceApps.Api/Models/FileRecord.cs
namespace InvoiceApps.Api.Models
{
    public class FileRecord
    {
        public int Id { get; set; }
        public string FileName { get; set; } = null!;
        public string FilePath { get; set; } = null!;
        public string ContentType { get; set; } = null!;
        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
    }
}
