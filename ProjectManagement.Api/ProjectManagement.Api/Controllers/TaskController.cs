using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManagement.Api.Controllers
{
    [ApiController]
    [Route("api/Task")]
    public class TaskController : BaseController<Task>
    {

        [HttpGet]
        public IActionResult GetAllTasks()
        {
            return base.Get();
        }

        [HttpGet]
        [Route("{taskId}")]
        public IActionResult GetTask(long taskId)
        {
            return base.Get(taskId);
        }

        [HttpPut]
        public IActionResult UpdateTask([FromBody] Task taskDetail)
        {
                return base.Put();
        }

        [HttpPost]
        public IActionResult CreateTask([FromBody] Task taskDetail)
        {
            return base.Post();
        }
        
        public IActionResult DeleteTask([FromBody] Task taskDetail)
        {
            return base.Delete();
        }
    }
}
