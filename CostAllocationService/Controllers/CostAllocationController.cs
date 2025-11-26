using Microsoft.AspNetCore.Mvc;
using CostAllocationService.DTOs;
using CostAllocationService.Models;
using CostAllocationService.Repositories;

namespace CostAllocationService.Controllers
{
    [ApiController]
    [Route("api/cost-allocation")]
    public class CostAllocationController : ControllerBase
    {
        private readonly ICostAllocationRepository _repo;

        public CostAllocationController(ICostAllocationRepository repo)
        {
            _repo = repo;
        }

        // --------------------------------------------------------------
        // GET ALL
        // --------------------------------------------------------------
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items = await _repo.GetAllAsync();
            return Ok(items);
        }

        // --------------------------------------------------------------
        // GET BY ID
        // --------------------------------------------------------------
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _repo.GetByIdAsync(id);
            if (item == null)
                return NotFound($"No cost allocation found with id {id}");

            return Ok(item);
        }

        // --------------------------------------------------------------
        // CREATE (POST)
        // --------------------------------------------------------------
        [HttpPost]
        public async Task<IActionResult> Create(CostAllocationDTO dto)
        {
            var entity = new CostAllocation
            {
                EntitlementId = dto.EntitlementId,
                DepartmentId = dto.DepartmentId,
                AllocationRule = dto.AllocationRule,
                Percentage = dto.Percentage,
                AllocatedCost = dto.AllocatedCost,
                CalculatedAt = DateTime.UtcNow
            };

            var saved = await _repo.AddAsync(entity);

            return CreatedAtAction(nameof(GetById), new { id = saved.Id }, saved);
        }

        // --------------------------------------------------------------
        // UPDATE (PUT)
        // --------------------------------------------------------------
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, CostAllocationDTO dto)
        {
            var entity = await _repo.GetByIdAsync(id);
            if (entity == null)
                return NotFound($"No cost allocation found with id {id}");

            entity.EntitlementId = dto.EntitlementId;
            entity.DepartmentId = dto.DepartmentId;
            entity.AllocationRule = dto.AllocationRule;
            entity.Percentage = dto.Percentage;
            entity.AllocatedCost = dto.AllocatedCost;
            entity.CalculatedAt = DateTime.UtcNow;

            var updated = await _repo.UpdateAsync(entity);

            return Ok(updated);
        }

        // --------------------------------------------------------------
        // DELETE
        // --------------------------------------------------------------
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _repo.DeleteAsync(id);
            if (!deleted)
                return NotFound($"No cost allocation found with id {id}");

            return Ok($"Deleted allocation with id {id}");
        }
    }
}
