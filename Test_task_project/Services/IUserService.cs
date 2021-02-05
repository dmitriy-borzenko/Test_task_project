using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_task_project.Core.Models;

namespace Test_task_project.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        User UpdateUser(User user);
    }
}
