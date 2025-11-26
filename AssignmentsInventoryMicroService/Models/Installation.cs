using System;
using System.Text.Json.Serialization;

namespace AssignmentsInventoryMicroService.Models
{
    public class Installation
    {
        public Guid InstallationId { get; set; } = Guid.NewGuid();

        public Guid DeviceId { get; set; }
        [JsonIgnore]                      // avoid circular JSON (Device -> Installations -> Device...)
        public Device? Device { get; set; }

        // logical links to other microservices
        public Guid? ProductId { get; set; }        // software_catalog.product_id
        public Guid? EntitlementId { get; set; }    // entitlements.entitlement_id

        public string Version { get; set; } = "1.0";
        public DateTime InstallDate { get; set; } = DateTime.UtcNow;
        public DateTime LastSeen { get; set; } = DateTime.UtcNow;
        public bool Discovered { get; set; } = true;
    }
}
