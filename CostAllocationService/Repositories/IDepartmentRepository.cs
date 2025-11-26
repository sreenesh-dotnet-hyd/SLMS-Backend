using CostAllocationService.Models;

namespace CostAllocationService.Repositories
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetAllAsync();
        Task<Department?> GetByIdAsync(int id);
        Task<Department> AddAsync(Department entity);
        Task<Department?> UpdateAsync(Department entity);
        Task<bool> DeleteAsync(int id);
    }
}
