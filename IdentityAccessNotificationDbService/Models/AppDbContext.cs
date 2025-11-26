using Microsoft.EntityFrameworkCore;

namespace IdentityAccessNotificationDbService.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<AuditLog> AuditLogs { get; set; }

        public DbSet<Permission> Permissions { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<RolePermission> RolePermissions { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<WorkFlow> WorkFlows { get; set; }

    }
}
