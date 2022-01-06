using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiDec31.Models;

namespace WebApiDec31.Data
{
    public class WebApiDec31Context : DbContext
    {
        public WebApiDec31Context (DbContextOptions<WebApiDec31Context> options)
            : base(options)
        {
        }

        public DbSet<WebApiDec31.Models.MyTask> MyTask { get; set; }
    }
}
