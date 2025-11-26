namespace IdentityAccessNotificationDbService.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public string DepartmentId{ get; set; }
        public int ManagerId { get; set; }
        
        // 0 - inactive, 1 - active
        public int Status { get; set; }

        public DateTime CreatedAt { get; set; } 

        public DateTime UpdatedAt { get; set; }

    }
}
