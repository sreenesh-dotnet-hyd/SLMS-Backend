namespace CatalogLicensingDbService.Models
{
    public class EntitlementFinance
    {
        public int Id { get; set; }

        public int EntitlementId { get; set; }
        public Entitlement Entitlement { get; set; }

        public decimal CostTotal { get; set; }
        public decimal CostPerSeat { get; set; }
        public string Currency { get; set; }
        public CapexOpex CapexOpex { get; set; }
        public string CostCenter { get; set; }
        public string DepreciationSchedule { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
