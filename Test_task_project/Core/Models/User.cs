using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test_task_project.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        [MaxLength(500)]
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
