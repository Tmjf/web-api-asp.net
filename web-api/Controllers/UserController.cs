using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_api.Data.Services;
using web_api.Data.ViewModels;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("add-user")] // custom route
        public IActionResult AddUser([FromBody]UserVM user)
        {
            _userService.AddUser(user);
            return Ok();
        }
    }
}
