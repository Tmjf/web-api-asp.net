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

        [HttpGet("getAllUsers")]
        public IActionResult GetAllUsers()
        {
            var allUsers = _userService.GetAllUsers();
            return Ok(allUsers);
        }

        [HttpGet("get-userById/{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _userService.GetUserById(id);
            return Ok(user);
        }

        [HttpPost("add-user")] // custom route
        public IActionResult AddUser([FromBody]UserVM user)
        {
            _userService.AddUser(user);
            return Ok();
        }

        [HttpPut(("update-userById/{id}"))]
        public IActionResult UpdateUserById(int id, [FromBody]UserVM user)
        {
            var updatedUser = _userService.UpdateUserById(id, user);
            return Ok(updatedUser);
        }

        [HttpDelete(("delete-userById/{id}"))]
        public IActionResult DeleteUserById(int id)
        {
            _userService.DeleteUserById(id);
            return Ok();
        }
    }
}