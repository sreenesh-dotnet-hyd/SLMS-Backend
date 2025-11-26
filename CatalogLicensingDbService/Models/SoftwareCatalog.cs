using System.ComponentModel.DataAnnotations;

namespace CatalogLicensingDbService.Models
{
    public class SoftwareCatalog
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Vendor { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public SoftwareStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Navigation
        public ICollection<LicenseType> LicenseTypes { get; set; }
    }
}
