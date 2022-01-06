using DotnetDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Student>> GetAllStudents()
        {
            return Ok(new List<Student>
                                                              {
                {
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rakesh",
                        Grade =100
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Vital",
                        Grade =200
                    }
                });


        } 

    }
}
