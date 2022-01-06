using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyWebApp1.Data;
using MyWebApp1.Model;

namespace MyWebApp1.Pages.TaskPage
{
    public class EditModel : PageModel
    {
        private readonly MyWebApp1.Data.MyWebApp1Context _context;

        public EditModel(MyWebApp1.Data.MyWebApp1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public MyTask MyTask { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyTask = await _context.MyTask.FirstOrDefaultAsync(m => m.ID == id);

            if (MyTask == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MyTask).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MyTaskExists(MyTask.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MyTaskExists(int id)
        {
            return _context.MyTask.Any(e => e.ID == id);
        }
    }
}
