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
    public class TaskTablesController : ControllerBase
    {
        private readonly CaseStudyContext _context;

        public TaskTablesController(CaseStudyContext context)
        {
            _context = context;
        }

        // GET: api/TaskTables
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskTable>>> GetTaskTable()
        {
            return await _context.TaskTable.ToListAsync();
        }

        // GET: api/TaskTables/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskTable>> GetTaskTable(int id)
        {
            var taskTable = await _context.TaskTable.FindAsync(id);

            if (taskTable == null)
            {
                return NotFound();
            }

            return taskTable;
        }

        // PUT: api/TaskTables/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaskTable(int id, TaskTable taskTable)
        {
            if (id != taskTable.ID)
            {
                return BadRequest();
            }

            _context.Entry(taskTable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskTableExists(id))
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

        // POST: api/TaskTables
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TaskTable>> PostTaskTable(TaskTable taskTable)
        {
            _context.TaskTable.Add(taskTable);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTaskTable", new { id = taskTable.ID }, taskTable);
        }

        // DELETE: api/TaskTables/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTaskTable(int id)
        {
            var taskTable = await _context.TaskTable.FindAsync(id);
            if (taskTable == null)
            {
                return NotFound();
            }

            _context.TaskTable.Remove(taskTable);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TaskTableExists(int id)
        {
            return _context.TaskTable.Any(e => e.ID == id);
        }
    }
}
