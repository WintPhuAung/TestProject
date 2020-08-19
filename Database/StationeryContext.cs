using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;


namespace WebApplication1.Database
{
    public class StationeryContext : DbContext
    {
        public StationeryContext(DbContextOptions<StationeryContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder model)
        {

        }

        public DbSet<Employee> employees { get; set; }
    }
}



