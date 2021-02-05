using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_task_project.Core;
using Test_task_project.Core.Models;

namespace Test_task_project.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext db;
        public UserRepository(UserContext db)
        {
            this.db = db;
        }
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await db.Users.ToListAsync();
        }

        public async Task<User> Update(User user)
        {
            var result = await db.Users.FirstOrDefaultAsync(u => u.Id == user.Id);
            if (result != null)
            {
                result.Active = user.Active;
                await db.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
