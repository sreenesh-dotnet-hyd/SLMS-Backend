namespace IdentityAccessNotificationDbService.Models
{
    public class notifications
    {
        public int id   { get; set; }
        public int user_id { get; set; }
        public string type { get; set; }
        public NotificationChannel Channel { get; set; }
    }
    public enum NotificationChannel
    {
        Email,
        Slack,
        Webhook,
        InApp
    }

}
