using System;

namespace AssignmentsInventoryMicroService.Models
{
    public class ComplianceAuditSnapshot
    {
        public Guid AuditId { get; set; } = Guid.NewGuid();

        public Guid ProductId { get; set; }        // logical
        public DateTime SnapshotTime { get; set; } = DateTime.UtcNow;

        public int AssignedCount { get; set; }
        public int UsedCount { get; set; }
        public int EntitlementsPurchased { get; set; }
        public string Status { get; set; } = "Compliant"; // Compliant / OverLicensed / UnderLicensed
    }
}
