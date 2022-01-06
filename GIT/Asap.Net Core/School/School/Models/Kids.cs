using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class School
    {
             [Key]
             public int StudId { get; set; }
             public string StudName { get; set; }

            [DataType(DataType.Date)]
            public DateTime Studjoining { get; set; }
            public string StudFather { get; set; }
    }
}
