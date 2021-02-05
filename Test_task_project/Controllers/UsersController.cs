using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_task_project.Core.Models;
using Test_task_project.Services;

namespace Test_task_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        // GET: api/Users
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = userService.GetUsers();
            return Ok(users);
        }

        [HttpPut("{id}")]
        public ActionResult PutUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            try
            {
                this.userService.UpdateUser(user);

            }
            catch (DbUpdateConcurrencyException)
            {

                return NotFound();

            }

            return NoContent();
        }
    }
}
