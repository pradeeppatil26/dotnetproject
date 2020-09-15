using Castle.Core.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        DbSet<Dept> depts { get; set; }
        DbSet<Employee> employes { get; set; }
        DbSet<Blog> blogs { get; set; }
        DbSet<Post> posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     => optionsBuilder
         .UseLazyLoadingProxies();
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
                
        }
    }
}
