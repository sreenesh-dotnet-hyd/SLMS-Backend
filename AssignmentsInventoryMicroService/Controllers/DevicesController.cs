using AssignmentsInventoryMicroService.Models;
using AssignmentsInventoryMicroService.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsInventoryMicroService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DevicesController : ControllerBase
    {
        private readonly IDeviceRepository _repo;

        public DevicesController(IDeviceRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Device>>> GetAll()
        {
            var devices = await _repo.GetAllAsync();
            return Ok(devices);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<Device>> GetById(Guid id)
        {
            var device = await _repo.GetByIdAsync(id);
            if (device == null) return NotFound();
            return Ok(device);
        }

        [HttpPost]
        public async Task<ActionResult<Device>> Create(Device device)
        {
            await _repo.AddAsync(device);
            await _repo.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = device.DeviceId }, device);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, Device updated)
        {
            var existing = await _repo.GetByIdAsync(id);
            if (existing == null) return NotFound();

            existing.Hostname = updated.Hostname;
            existing.DeviceType = updated.DeviceType;
            existing.Status = updated.Status;
            existing.DepartmentId = updated.DepartmentId;
            existing.OwnerUserId = updated.OwnerUserId;
            existing.LastSeen = updated.LastSeen;

            await _repo.UpdateAsync(existing);
            await _repo.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _repo.DeleteAsync(id);
            await _repo.SaveChangesAsync();
            return NoContent();
        }
    }
}
