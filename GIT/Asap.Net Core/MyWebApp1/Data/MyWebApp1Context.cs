using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWebApp1.Model;

namespace MyWebApp1.Data
{
    public class MyWebApp1Context : DbContext
    {
        public MyWebApp1Context (DbContextOptions<MyWebApp1Context> options)
            : base(options)
        {
        }

        public DbSet<MyWebApp1.Model.MyTask> MyTask { get; set; }
    }
}
