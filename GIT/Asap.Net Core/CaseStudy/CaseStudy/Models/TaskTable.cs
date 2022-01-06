using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudy.Models
{
    public class TaskTable
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime TargetDate { get; set; }
        public string Status { get; set; }
        public int OwnerId { get; set; }
        public string Priority { get; set; }
        public string Tags { get; set; }
        
    }
}
