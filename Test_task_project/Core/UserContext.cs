using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_task_project.Core.Models;

namespace Test_task_project.Core
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .Property(b => b.Active)
            .HasDefaultValue(false);

            modelBuilder.Entity<User>().HasData(
                new User[]
                {
                new User { Id=1, Name="Tom", Active=false},
                new User { Id=2, Name="Alice",Active=false},
                new User { Id=3, Name="Mike",Active=false},
                new User { Id=4, Name="Bill",Active=false},
                new User { Id=5, Name="Sam",Active=false},
                new User { Id=6, Name="Barry",Active=false},
                new User { Id=7, Name="Marry",Active=false},
                new User { Id=8, Name="Donald",Active=false},
                new User { Id=9, Name="Jerry",Active=false},
                new User { Id=10, Name="Fill",Active=false}
                });
        }
    }
}
