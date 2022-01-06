using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp1.Model
{
    public class MyTask
    {
        public int ID { get; set; }

        public string Description { get; set; }
        
        public DateTime TargetDate { get; set; }
    }
}
