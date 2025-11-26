using System;

namespace AssignmentsInventoryMicroService.Models
{
    public class UsageEvent
    {
        public Guid UsageEventId { get; set; } = Guid.NewGuid();

        public Guid? UserId { get; set; }          // logical
        public Guid? DeviceId { get; set; }        // FK to Device (nullable, e.g. SaaS)
        public Device? Device { get; set; }

        public Guid ProductId { get; set; }        // logical
        public string EventType { get; set; } = "session_start"; // login / session_start / session_end / launch_app ...
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        public Guid? SessionId { get; set; }
        public int? DurationSeconds { get; set; }
    }
}
