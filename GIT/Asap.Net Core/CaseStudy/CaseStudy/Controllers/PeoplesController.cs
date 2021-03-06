using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CaseStudy.Data;
using CaseStudy.Models;

namespace CaseStudy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeoplesController : ControllerBase
    {
        private readonly CaseStudyContext _context;

        public PeoplesController(CaseStudyContext context)
        {
            _context = context;
        }

        // GET: api/Peoples
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Peoples>>> GetPeoples()
        {
            return await _context.Peoples.ToListAsync();
        }

        // GET: api/Peoples/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Peoples>> GetPeoples(int id)
        {
            var peoples = await _context.Peoples.FindAsync(id);

            if (peoples == null)
            {
                return NotFound();
            }

            return peoples;
        }

        // PUT: api/Peoples/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPeoples(int id, Peoples peoples)
        {
            if (id != peoples.ID)
            {
                return BadRequest();
            }

            _context.Entry(peoples).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeoplesExists(id))
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

        // POST: api/Peoples
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Peoples>> PostPeoples(Peoples peoples)
        {
            _context.Peoples.Add(peoples);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPeoples", new { id = peoples.ID }, peoples);
        }

        // DELETE: api/Peoples/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePeoples(int id)
        {
            var peoples = await _context.Peoples.FindAsync(id);
            if (peoples == null)
            {
                return NotFound();
            }

            _context.Peoples.Remove(peoples);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PeoplesExists(int id)
        {
            return _context.Peoples.Any(e => e.ID == id);
        }
    }
}
