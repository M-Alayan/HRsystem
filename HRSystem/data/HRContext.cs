using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HRSystem.data
{
    public class HRContext:DbContext
    {
     public   DbSet<Country> country { set; get; }
       public DbSet<Department> department { set; get; }
       public DbSet<Employee> employee { set; get; }
       public DbSet<City> city { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=localhost; initial catalog=HRSystem; integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
