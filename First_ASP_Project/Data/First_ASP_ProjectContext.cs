using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using First_ASP_Project.Models;

namespace First_ASP_Project.Data
{
    public class First_ASP_ProjectContext : DbContext
    {
        public First_ASP_ProjectContext (DbContextOptions<First_ASP_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<First_ASP_Project.Models.Movie> Movie { get; set; } = default!;
    }
}
