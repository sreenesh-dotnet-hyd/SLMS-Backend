namespace CatalogLicensingDbService.Models
{
    public class Procurement
    {
        public int Id { get; set; }

        public string PurchaseOrderNumber { get; set; }
        public string ContractId { get; set; }
        public string InvoiceId { get; set; }
        public string ResellerName { get; set; }
        public SupportLevel SupportLevel { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Navigation
        public ICollection<ProcurementEntitlementMap> ProcurementEntitlements { get; set; }
    }
}
