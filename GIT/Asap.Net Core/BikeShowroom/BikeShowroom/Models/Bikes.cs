using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShowroom.Models
{
    public class Bikes
    {
        [Key]
        public int BikeNums { get; set; }
        public string BikeNames { get; set; }
        public int BikeModel { get; set; }
        public string BikeVerison { get; set; }

    }
}
