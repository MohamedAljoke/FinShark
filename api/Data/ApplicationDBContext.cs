using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {

        protected readonly IConfiguration Configuration;
        // ctor 
        // prop
        public ApplicationDBContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Configuration.GetConnectionString("Database"));
        }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Comment> Comment { get; set; }

    }
}