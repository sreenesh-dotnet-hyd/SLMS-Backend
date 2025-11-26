namespace IdentityAccessNotificationDbService.Models
{
    public class WorkFlow
    {
        public int Id { get; set; }

        // ENUM fields
        public WorkflowType Type { get; set; }
        public WorkflowStatus Status { get; set; }

        // Foreign Keys
        public int RequestedBy { get; set; }
        public int? ApprovedBy { get; set; }

        // Navigation Properties
        public User RequestedByUser { get; set; }
        public User ApprovedByUser { get; set; }

        // Workflow entity reference
        public string EntityType { get; set; }
        public string EntityId { get; set; }

        // JSON payload
        public string Payload { get; set; }

        // Timestamps
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
public enum WorkflowType
{
    AssignLicense,
    ReclaimLicense,
    Custom
}

public enum WorkflowStatus
{
    Pending,
    Approved,
    Rejected,
    Completed,
    Cancelled
}

}
