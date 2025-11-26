using CostAllocationService.Data;
using CostAllocationService.Models;
using Microsoft.EntityFrameworkCore;

namespace CostAllocationService.Repositories
{
    public class CostAllocationRepository : ICostAllocationRepository
    {
        private readonly AppDbContext _context;

        public CostAllocationRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CostAllocation>> GetAllAsync()
        {
            return await _context.CostAllocations.ToListAsync();
        }

        public async Task<CostAllocation?> GetByIdAsync(int id)
        {
            return await _context.CostAllocations.FindAsync(id);
        }

        public async Task<CostAllocation> AddAsync(CostAllocation entity)
        {
            _context.CostAllocations.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<CostAllocation?> UpdateAsync(CostAllocation entity)
        {
            var existing = await _context.CostAllocations.FindAsync(entity.Id);
            if (existing == null)
                return null;

            _context.Entry(existing).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();

            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var existing = await _context.CostAllocations.FindAsync(id);
            if (existing == null)
                return false;

            _context.CostAllocations.Remove(existing);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
