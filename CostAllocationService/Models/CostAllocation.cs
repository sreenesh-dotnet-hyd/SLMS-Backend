namespace CostAllocationService.Models
{
    public class CostAllocation
    {
        public int Id { get; set; }
        public int EntitlementId { get; set; }
        public int DepartmentId { get; set; }
        public string AllocationRule { get; set; } // per_user | per_install | fixed_split
        public decimal Percentage { get; set; }
        public decimal AllocatedCost { get; set; }
        public DateTime CalculatedAt { get; set; }

        public Department Department { get; set; }
    }
}
