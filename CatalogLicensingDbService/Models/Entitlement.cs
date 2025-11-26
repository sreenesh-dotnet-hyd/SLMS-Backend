using System.ComponentModel.DataAnnotations;

namespace CatalogLicensingDbService.Models
{
    public class Entitlement
    {
        public int Id { get; set; }

        public int LicenseTypeId { get; set; }
        public LicenseType LicenseType { get; set; }

        public string Sku { get; set; }
        public int SeatsPurchased { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string ActivationMethod { get; set; }
        public string VendorInvoicePath { get; set; }
        public EntitlementStatus Status { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Navigation
        public EntitlementFinance Finance { get; set; }
        public ICollection<ProcurementEntitlementMap> ProcurementMaps { get; set; }
    }
}
