using System.ComponentModel.DataAnnotations;

namespace CatalogLicensingDbService.Models
{
    public class LicenseType
    {
        public int Id { get; set; }

        public int SoftwareCatalogId { get; set; }
        public SoftwareCatalog SoftwareCatalog { get; set; }

        public LicenseTypeEnum LicenseTypeName { get; set; }
        public MetricEnum Metric { get; set; }
        public ConsumptionEnum ConsumptionMethod { get; set; }
        public EnforcementEnum EnforcementType { get; set; }
        public string VendorTerms { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Navigation
        public ICollection<Entitlement> Entitlements { get; set; }
    }
}
