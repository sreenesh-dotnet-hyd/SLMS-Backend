using Microsoft.AspNetCore.Mvc;
using CostAllocationService.DTOs;
using CostAllocationService.Models;
using CostAllocationService.Repositories;

namespace CostAllocationService.Controllers
{
    [ApiController]
    [Route("api/departments")]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository _repo;

        public DepartmentsController(IDepartmentRepository repo)
        {
            _repo = repo;
        }

        // --------------------------------------------------------------
        // CREATE
        // --------------------------------------------------------------
        [HttpPost]
        public async Task<IActionResult> CreateDepartment(DepartmentDTO dto)
        {
            var dept = new Department
            {
                Name = dto.Name,
                ManagerId = dto.ManagerId
            };

            var saved = await _repo.AddAsync(dept);
            return CreatedAtAction(nameof(GetById), new { id = saved.Id }, saved);
        }

        // --------------------------------------------------------------
        // READ ALL
        // --------------------------------------------------------------
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _repo.GetAllAsync());
        }

        // --------------------------------------------------------------
        // READ BY ID
        // --------------------------------------------------------------
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var dept = await _repo.GetByIdAsync(id);
            if (dept == null)
                return NotFound($"Department with ID {id} not found");

            return Ok(dept);
        }

        // --------------------------------------------------------------
        // UPDATE
        // --------------------------------------------------------------
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, DepartmentDTO dto)
        {
            var existing = await _repo.GetByIdAsync(id);
            if (existing == null)
                return NotFound($"Department with ID {id} not found");

            existing.Name = dto.Name;
            existing.ManagerId = dto.ManagerId;

            var updated = await _repo.UpdateAsync(existing);
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
                return NotFound($"Department with ID {id} not found");

            return Ok($"Department with ID {id} deleted");
        }
    }
}
