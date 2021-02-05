using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_task_project.Core.Models;
using Test_task_project.Repository;

namespace Test_task_project.Services
{
    public class UserService : IUserService
    {
        private IUserRepository repository;
        public UserService(IUserRepository repository)
        {
            this.repository = repository;
        }
        public IEnumerable<User> GetUsers()
        {
            return repository.GetUsers().Result;
        }

        public User UpdateUser(User user)
        {
            return repository.Update(user).Result;
        }
    }
}
