using CostAllocationService.Models;

namespace CostAllocationService.Repositories
{
    public interface ICostAllocationRepository
    {
        Task<IEnumerable<CostAllocation>> GetAllAsync();
        Task<CostAllocation?> GetByIdAsync(int id);
        Task<CostAllocation> AddAsync(CostAllocation entity);
        Task<CostAllocation?> UpdateAsync(CostAllocation entity);
        Task<bool> DeleteAsync(int id);
    }
}
