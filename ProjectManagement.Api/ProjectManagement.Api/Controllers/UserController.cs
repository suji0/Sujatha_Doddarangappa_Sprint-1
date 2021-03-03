using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Api.Controllers
{
    [ApiController]
    [Route("api/User")]
    public class UserController : BaseController<User>
    {
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return base.Get();
        }

        [HttpGet]
        [Route("{userId}")]
        public IActionResult GetUser(long userId)
        {
            return base.Get(userId);
        }

        [HttpPut]
        public IActionResult UpdateUser([FromBody] User userDetail)
        {
            return base.Put();
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] User userDetail)
        {
            return base.Post();
        }

        public IActionResult DeleteUser([FromBody] User userDetail)
        {
            return base.Delete();
        }

    }
}
