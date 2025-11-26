using System;
using System.Collections.Generic;

namespace AssignmentsInventoryMicroService.Models
{
    public class Device
    {
        public Guid DeviceId { get; set; } = Guid.NewGuid();
        public string Hostname { get; set; } = null!;
        public Guid? DepartmentId { get; set; }      // logical link to Department (other service)
        public Guid? OwnerUserId { get; set; }       // logical link to Users (other service)
        public string DeviceType { get; set; } = "Laptop";
        public DateTime LastSeen { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = "Active";   // Active / Inactive / Retired

        public ICollection<Installation> Installations { get; set; } = new List<Installation>();
    }
}
