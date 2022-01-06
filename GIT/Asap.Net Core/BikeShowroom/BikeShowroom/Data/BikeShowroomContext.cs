using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BikeShowroom.Models;

namespace BikeShowroom.Data
{
    public class BikeShowroomContext : DbContext
    {
        public BikeShowroomContext (DbContextOptions<BikeShowroomContext> options)
            : base(options)
        {
        }

        public DbSet<BikeShowroom.Models.Bikes> Bikes { get; set; }
    }
}
