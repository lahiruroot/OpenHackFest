using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployAPI.Model;

namespace EmployAPI.Data
{
    public class EmployAPIContext : DbContext
    {
        public EmployAPIContext (DbContextOptions<EmployAPIContext> options)
            : base(options)
        {
        }

        public DbSet<EmployAPI.Model.Employ> Employ { get; set; } = default!;
    }
}
