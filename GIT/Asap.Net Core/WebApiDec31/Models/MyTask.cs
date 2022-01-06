using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDec31.Models
{
    public class MyTask
    {
        public int ID { get; set; }
        public string TaskDesc { get; set; }
        public string TaskOwner { get; set; }
    }
}
