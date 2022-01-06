using BikeShowroom.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShowroom.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BikeShowroomContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BikeShowroomContext>>()))
            {
                // Look for any movies.
                if (context.Bikes.Any())
                {
                    return;   // DB has been seeded
                }

                context.Bikes.AddRange(
                new Bikes
                {

                    BikeNames = "Plusar",
                    BikeModel = 2021,
                    BikeVerison = "forth"

                },
                new Bikes
                {
                    BikeNames = "R15",
                    BikeModel = 2021,
                    BikeVerison = "forth"

                }

            );
                context.SaveChanges();
            }


        }
    }
        
}
