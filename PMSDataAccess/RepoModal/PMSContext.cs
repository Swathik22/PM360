using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccess.RepoModal
{
    public class PMSContext : DbContext
    {
        public DbSet<UserDetail> UserDetails { get; set; }

        public DbSet<RoleDetail> RoleDetails { get; set; }

        public DbSet<AssessmentDetail> AssessmentDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-IV4PIL8;DataBase=PMS360DB;Integrated Security=true;");
            }
            base.OnConfiguring(optionsBuilder);
            //base is DBContext
        }
    }
}
