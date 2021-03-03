using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Api.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public bool LoginUser(int userId, string password)
        {
            var result = false;
            // User login 
            return result;
        }
    }
}
