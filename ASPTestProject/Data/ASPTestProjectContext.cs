using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPTestProject.Models;

namespace ASPTestProject.Data
{
    public class ASPTestProjectContext : DbContext
    {
        public ASPTestProjectContext (DbContextOptions<ASPTestProjectContext> options)
            : base(options)
        {
        }

        public DbSet<ASPTestProject.Models.Movie> Movie { get; set; } = default!;
    }
}
