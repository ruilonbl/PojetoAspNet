using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNet.Models;

namespace AspNet.Data
{
    public class AspNetContext : DbContext
    {
        public AspNetContext (DbContextOptions<AspNetContext> options)
            : base(options)
        {
        }

        public DbSet<AspNet.Models.Department> Department { get; set; } = default!;
    }
}
