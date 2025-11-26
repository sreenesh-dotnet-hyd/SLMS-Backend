using CostAllocationService.Data;
using CostAllocationService.Models;
using Microsoft.EntityFrameworkCore;

namespace CostAllocationService.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _context;

        public DepartmentRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Department>> GetAllAsync()
        {
            return await _context.Departments.ToListAsync();
        }

        public async Task<Department?> GetByIdAsync(int id)
        {
            return await _context.Departments.FindAsync(id);
        }

        public async Task<Department> AddAsync(Department entity)
        {
            _context.Departments.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Department?> UpdateAsync(Department entity)
        {
            var existing = await _context.Departments.FindAsync(entity.Id);
            if (existing == null)
                return null;

            _context.Entry(existing).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();

            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _context.Departments.FindAsync(id);
            if (entity == null)
                return false;

            _context.Departments.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
