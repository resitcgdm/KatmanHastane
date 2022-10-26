using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class HastaneContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-CGLV6T1\TEW_SQLEXPRESS;Database=HospitalDb2;Trusted_Connection=True");
        }
       public DbSet<Hastane> Hospitals { get; set; }
        public DbSet<Admin> Admins { get; set; }
      
    }
}
