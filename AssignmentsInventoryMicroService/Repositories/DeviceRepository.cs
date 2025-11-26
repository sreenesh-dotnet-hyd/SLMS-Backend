using AssignmentsInventoryMicroService.Data;
using AssignmentsInventoryMicroService.Models;
using Microsoft.EntityFrameworkCore;

namespace AssignmentsInventoryMicroService.Repositories
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly AssignmentsInventoryDbContext _db;

        public DeviceRepository(AssignmentsInventoryDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Device>> GetAllAsync()
        {
            return await _db.Devices
                .Include(d => d.Installations)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Device?> GetByIdAsync(Guid id)
        {
            return await _db.Devices
                .Include(d => d.Installations)
                .FirstOrDefaultAsync(d => d.DeviceId == id);
        }

        public async Task AddAsync(Device device)
        {
            await _db.Devices.AddAsync(device);
        }

        public Task UpdateAsync(Device device)
        {
            _db.Devices.Update(device);
            return Task.CompletedTask;
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _db.Devices.FindAsync(id);
            if (entity != null)
            {
                _db.Devices.Remove(entity);
            }
        }

        public async Task SaveChangesAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
