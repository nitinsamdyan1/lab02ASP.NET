using LabWebApp.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using LabWebApp.Models;

namespace LabWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
