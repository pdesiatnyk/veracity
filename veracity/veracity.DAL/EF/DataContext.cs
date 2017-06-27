using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veracity.DAL.Entities;

namespace veracity.DAL.EF 
{
    public class DataContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Entities.Task> Tasks { get; set; }
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<Site_Statistic> Site_Statistics { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DataContext(): base("DbConnection")
        {

        }
    }
}
