using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmployAPI.Data;
using EmployAPI.Model;

namespace EmployAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmploysController : ControllerBase
    {
        private readonly EmployAPIContext _context;

        public EmploysController(EmployAPIContext context)
        {
            _context = context;
        }

        // GET: api/Employs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employ>>> GetEmploy()
        {
          if (_context.Employ == null)
          {
              return NotFound();
          }
            return await _context.Employ.ToListAsync();
        }

        // GET: api/Employs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employ>> GetEmploy(int id)
        {
          if (_context.Employ == null)
          {
              return NotFound();
          }
            var employ = await _context.Employ.FindAsync(id);

            if (employ == null)
            {
                return NotFound();
            }

            return employ;
        }

        // PUT: api/Employs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmploy(int id, Employ employ)
        {
            if (id != employ.Id)
            {
                return BadRequest();
            }

            _context.Entry(employ).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployExists(id))
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

        // POST: api/Employs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Employ>> PostEmploy(Employ employ)
        {
          if (_context.Employ == null)
          {
              return Problem("Entity set 'EmployAPIContext.Employ'  is null.");
          }
            _context.Employ.Add(employ);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmploy", new { id = employ.Id }, employ);
        }

        // DELETE: api/Employs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmploy(int id)
        {
            if (_context.Employ == null)
            {
                return NotFound();
            }
            var employ = await _context.Employ.FindAsync(id);
            if (employ == null)
            {
                return NotFound();
            }

            _context.Employ.Remove(employ);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployExists(int id)
        {
            return (_context.Employ?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
