using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyWebApp1.Data;
using MyWebApp1.Model;

namespace MyWebApp1.Pages.TaskPage
{
    public class IndexModel : PageModel
    {
        private readonly MyWebApp1.Data.MyWebApp1Context _context;

        public IndexModel(MyWebApp1.Data.MyWebApp1Context context)
        {
            _context = context;
        }

        public IList<MyTask> MyTask { get;set; }

        public async Task OnGetAsync()
        {
            MyTask = await _context.MyTask.ToListAsync();
        }
    }
}
