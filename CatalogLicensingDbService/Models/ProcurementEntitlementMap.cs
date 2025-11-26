namespace CatalogLicensingDbService.Models
{
    public class ProcurementEntitlementMap
    {
        public int Id { get; set; }

        public int ProcurementId { get; set; }
        public Procurement Procurement { get; set; }

        public int EntitlementId { get; set; }
        public Entitlement Entitlement { get; set; }
    }
}
