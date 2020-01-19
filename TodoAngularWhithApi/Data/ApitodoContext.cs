using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TodoAngularWhithApi.Models
{
    public class ApitodoContext : DbContext
    {
        public ApitodoContext (DbContextOptions<ApitodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoAngularWhithApi.Models.TodoTask> TodoTask { get; set; }
    }
}
