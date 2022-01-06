using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDec31.Models;

namespace WebApiDec31.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyTasksController : ControllerBase
    {
        static List<MyTask> list = new List<MyTask>
        {
            new MyTask{ID=1,TaskDesc="Web API Demo",TaskOwner="Mary"},
            new MyTask{ID=2,TaskDesc="Web API HOL",TaskOwner="ETGs"}
        };
        [HttpGet]
        [EnableQuery]
        public IEnumerable<MyTask> Get()
        {
            return list;
        }

        [HttpGet]
        [Route("/tasks/{owner}")]
        public IEnumerable<MyTask> Get(string owner)
        {
            IEnumerable<MyTask> res = list.Where(x => x.TaskOwner == owner);
            return res;
        }
        [HttpPost]
        public void Post(MyTask t)
        {
            list.Add(t);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            MyTask t = list.FirstOrDefault(x => x.ID == id);
            list.Remove(t);
        }
        
    }
   
    
    
}
