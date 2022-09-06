using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiApplication.viewModel;

namespace WebApiApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employees1Controller : ControllerBase
    {
        private readonly EmployeeDbContext _context;

        public Employees1Controller(EmployeeDbContext context)
        {
            _context = context;
        }

        // GET: api/Employees1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employees>>> GetEmployees()
        {
          if (_context.Employees == null)
          {
              return NotFound();
          }
            return await _context.Employees.ToListAsync();
        }

        // GET: api/Employees1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employees>> GetEmployees(Guid id)
        {
          if (_context.Employees == null)
          {
              return NotFound();
          }
            var employees = await _context.Employees.FindAsync(id);

            if (employees == null)
            {
                return NotFound();
            }

            return employees;
        }

        // PUT: api/Employees1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployees(Guid id, Employees employees)
        {
            if (id != employees.EmployeeId)
            {
                return BadRequest();
            }

            _context.Entry(employees).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Employees1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Employees>> PostEmployees(Employees employees)
        {
          if (_context.Employees == null)
          {
              return Problem("Entity set 'EmployeeDbContext.Employees'  is null.");
          }
            _context.Employees.Add(employees);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployees", new { id = employees.EmployeeId }, employees);
        }

        // DELETE: api/Employees1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployees(Guid id)
        {
            if (_context.Employees == null)
            {
                return NotFound();
            }
            var employees = await _context.Employees.FindAsync(id);
            if (employees == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(employees);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeesExists(Guid id)
        {
            return (_context.Employees?.Any(e => e.EmployeeId == id)).GetValueOrDefault();
        }
    }
}
