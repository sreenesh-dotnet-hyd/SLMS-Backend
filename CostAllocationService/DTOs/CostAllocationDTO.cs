namespace CostAllocationService.DTOs
{
    public class CostAllocationDTO
    {
        public int EntitlementId { get; set; }
        public int DepartmentId { get; set; }
        public string AllocationRule { get; set; }
        public decimal Percentage { get; set; }
        public decimal AllocatedCost { get; set; }
    }
}
