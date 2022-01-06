using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CaseStudy.Models;

namespace CaseStudy.Data
{
    public class CaseStudyContext : DbContext
    {
        public CaseStudyContext (DbContextOptions<CaseStudyContext> options)
            : base(options)
        {
        }

        public DbSet<CaseStudy.Models.TaskTable> TaskTable { get; set; }

        public DbSet<CaseStudy.Models.Peoples> Peoples { get; set; }
    }
}
