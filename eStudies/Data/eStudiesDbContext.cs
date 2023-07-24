using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eStudies.Models;

namespace eStudies.Data
{
    public class eStudiesDbContext : DbContext
    {
        public eStudiesDbContext (DbContextOptions<eStudiesDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Register> Registers { get; set; }
        public DbSet<Marks> Marks { get; set; }
        public DbSet<SResources> Resources { get; set; }
        public DbSet<AcademicProgress> AcademicProgress { get; set; }
    }
}
