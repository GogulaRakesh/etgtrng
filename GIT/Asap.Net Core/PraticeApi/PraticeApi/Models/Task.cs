using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticeApi.Models
{
    public class Task
    {
        [key]
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpBranch { get; set; }
        public int EmpAge { get; set; }
    }
}
