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
    public class AppraisalDetailsController : ControllerBase
    {
        private readonly EmployeeDbContext _context;

        public AppraisalDetailsController(EmployeeDbContext context)
        {
            _context = context;
        }

        // GET: api/AppraisalDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppraisalDetails>>> GetAppraisalDetails()
        {
          if (_context.AppraisalDetails == null)
          {
              return NotFound();
          }
            return await _context.AppraisalDetails.ToListAsync();
        }

        // GET: api/AppraisalDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AppraisalDetails>> GetAppraisalDetails(Guid id)
        {
          if (_context.AppraisalDetails == null)
          {
              return NotFound();
          }
            var appraisalDetails = await _context.AppraisalDetails.FindAsync(id);

            if (appraisalDetails == null)
            {
                return NotFound();
            }

            return appraisalDetails;
        }

        // PUT: api/AppraisalDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppraisalDetails(Guid id, AppraisalDetails appraisalDetails)
        {
            if (id != appraisalDetails.EmployeeNumber)
            {
                return BadRequest();
            }

            _context.Entry(appraisalDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppraisalDetailsExists(id))
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

        // POST: api/AppraisalDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AppraisalDetails>> PostAppraisalDetails(AppraisalDetails appraisalDetails)
        {
          if (_context.AppraisalDetails == null)
          {
              return Problem("Entity set 'EmployeeDbContext.AppraisalDetails'  is null.");
          }
            _context.AppraisalDetails.Add(appraisalDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppraisalDetails", new { id = appraisalDetails.EmployeeNumber }, appraisalDetails);
        }

        // DELETE: api/AppraisalDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppraisalDetails(Guid id)
        {
            if (_context.AppraisalDetails == null)
            {
                return NotFound();
            }
            var appraisalDetails = await _context.AppraisalDetails.FindAsync(id);
            if (appraisalDetails == null)
            {
                return NotFound();
            }

            _context.AppraisalDetails.Remove(appraisalDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AppraisalDetailsExists(Guid id)
        {
            return (_context.AppraisalDetails?.Any(e => e.EmployeeNumber == id)).GetValueOrDefault();
        }
    }
}
