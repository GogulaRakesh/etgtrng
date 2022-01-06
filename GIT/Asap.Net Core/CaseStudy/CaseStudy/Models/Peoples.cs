using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudy.Models
{
    public class Peoples
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }



        public string EmailId { get; set; }



        public ICollection<TaskTable> TaskTables { get; set; }
    }
}
