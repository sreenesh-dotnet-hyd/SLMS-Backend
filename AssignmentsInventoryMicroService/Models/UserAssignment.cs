using System;

namespace AssignmentsInventoryMicroService.Models
{
    public class UserAssignment
    {
        public Guid AssignmentId { get; set; } = Guid.NewGuid();

        // logical IDs – belong to other services
        public Guid UserId { get; set; }           // users.user_id
        public Guid ProductId { get; set; }        // software_catalog.product_id
        public Guid EntitlementId { get; set; }    // entitlements.entitlement_id

        public string Status { get; set; } = "Active"; // Active / Revoked / PendingReclaim / Exempt
        public DateTime AssignedAt { get; set; } = DateTime.UtcNow;
        public DateTime? RevokedAt { get; set; }
        public DateTime? LastUsedAt { get; set; }
        public bool ExemptFlag { get; set; } = false;
    }
}
