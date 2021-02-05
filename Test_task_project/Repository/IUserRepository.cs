using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_task_project.Core.Models;

namespace Test_task_project.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> Update(User user);
    }
}
