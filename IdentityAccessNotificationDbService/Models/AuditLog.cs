namespace IdentityAccessNotificationDbService.Models
{
    public class AuditLog
    {
        public int Id { get; set; }

        // Foreign Key → User who performed the action
        public int ActorId { get; set; }
        public User Actor { get; set; }

        // Action details
        public string Action { get; set; }
        public string EntityType { get; set; }
        public string EntityId { get; set; }

        // JSON data (stored as text in DB)
        public string OldValues { get; set; }
        public string NewValues { get; set; }

        // Timestamps
        public DateTime CreatedAt { get; set; }

        // Audit metadata
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
    }
}
