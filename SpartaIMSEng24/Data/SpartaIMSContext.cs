using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpartaIMSEng24.Models;

namespace SpartaIMSEng24.Data
{
    public class SpartaIMSContext : DbContext
    {
        public SpartaIMSContext(DbContextOptions<SpartaIMSContext> options) : base(options) { }

        public DbSet<SpartanUser> SpartanUsers { get; set; }
        public DbSet<Cohort> Cohorts { get; set; }
        public DbSet<JobRole> JobRoles { get; set; }
        public DbSet<Specialisation> Specialisations { get; set; }  
    }
}
