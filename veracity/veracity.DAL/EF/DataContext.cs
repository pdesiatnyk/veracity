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
            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
        }
        static DataContext()
        {
            Database.SetInitializer<DataContext>(new DbInitializer());
        }

    }
    public class DbInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext db)
        {
            Department d1 = new Department() { Name = "Department1" };
            Department d2 = new Department() { Name = "Department2" };
            db.Departments.AddRange(new List<Department> { d1, d2 });
            db.SaveChanges();

            Employee e1 = new Employee() { Login = "login1", Password = "pass1", Name = "Name1", Home_adress = "adress1", Phone_number = "phone1", IsManager = false, Salary=0, Departments = d1};
            Employee e2 = new Employee() { Login = "login2", Password = "pass2", Name = "Name2", Home_adress = "adress2", Phone_number = "phone2", IsManager = false, Salary = 0, Departments = d1};
            Employee e3 = new Employee() { Login = "login3", Password = "pass3", Name = "Name3", Home_adress = "adress3", Phone_number = "phone3", IsManager = false, Salary = 0, Departments = d2 };
            Employee e4 = new Employee() { Login = "login4", Password = "pass4", Name = "Name4", Home_adress = "adress4", Phone_number = "phone4", IsManager = false, Salary = 0, Departments = d2 };
            Employee m1 = new Employee() { Login = "man1", Password = "man1", Name = "man1", Home_adress = "adress5", Phone_number = "phone5", IsManager = true, Departments = d1 };
            Employee m2 = new Employee() { Login = "man2", Password = "man2", Name = "man2", Home_adress = "adress6", Phone_number = "phone6", IsManager = true, Departments = d2 };

            db.Employees.AddRange(new List<Employee> { e1, e2, e3, e4, m1, m2 });
            db.SaveChanges();

            Entities.Task t1 = new Entities.Task() { ID_employee = 1, Status = "in progress", Task_descr = "description1" };
            Entities.Task t2 = new Entities.Task() { ID_employee = 1, Status = "in progress", Task_descr = "description2" };
            Entities.Task t4 = new Entities.Task() { ID_employee = 2, Status = "in progress", Task_descr = "description3" };
            Entities.Task t3 = new Entities.Task() { ID_employee = 2, Status = "done", Task_descr = "description4" };
            Entities.Task t5 = new Entities.Task() { ID_employee = 3, Status = "done", Task_descr = "description5" };
            Entities.Task t6 = new Entities.Task() { ID_employee = 3, Status = "done", Task_descr = "description6" };
            Entities.Task t7 = new Entities.Task() { ID_employee = 4, Status = "done", Task_descr = "description7" };
            Entities.Task t8 = new Entities.Task() { ID_employee = 4, Status = "done", Task_descr = "description8" };
            db.Tasks.AddRange(new List<Entities.Task> { t1, t2, t3, t4, t5, t6, t7, t8 });
            db.SaveChanges();


            Achievement a1 = new Achievement() { ID_task = 1, Achievement_points = "30", Comment = "comment1", Tasks = t1 };
            Achievement a2 = new Achievement() { ID_task = 2, Achievement_points = "40", Comment = "comment2", Tasks = t2 };
            Achievement a3 = new Achievement() { ID_task = 3, Achievement_points = "50", Comment = "comment3", Tasks = t3 };
            Achievement a4 = new Achievement() { ID_task = 4, Achievement_points = "60", Comment = "comment4", Tasks = t4 };
            Achievement a5 = new Achievement() { ID_task = 5, Achievement_points = "70", Comment = "comment5", Tasks = t5 };
            Achievement a6 = new Achievement() { ID_task = 6, Achievement_points = "80", Comment = "comment6", Tasks = t6 };
            Achievement a7 = new Achievement() { ID_task = 7, Achievement_points = "90", Comment = "comment7", Tasks = t7 };
            Achievement a8 = new Achievement() { ID_task = 8, Achievement_points = "100", Comment = "comment8", Tasks = t8 };

            db.Achievements.AddRange(new List<Achievement> { a1,a2,a3,a4,a5,a6,a7,a8});
            db.SaveChanges();

            Site_Statistic s1 = new Site_Statistic() { ID_employee = 1, Datetime_of_record = new DateTime(2017, 06, 28, 8, 0, 0, 0), Start_working = new DateTime(2017, 06, 28, 8, 0, 0, 0), End_working = new DateTime(2017, 06, 28, 16, 0, 0, 0) };
            Site_Statistic s2 = new Site_Statistic() { ID_employee = 1, Datetime_of_record = new DateTime(2017, 06, 27, 8, 0, 0, 0), Start_working = new DateTime(2017, 06, 27, 8, 0, 0, 0), End_working = new DateTime(2017, 06, 27, 17, 0, 0, 0) };
            Site_Statistic s3 = new Site_Statistic() { ID_employee = 2, Datetime_of_record = new DateTime(2017, 06, 28, 8, 0, 0, 0), Start_working = new DateTime(2017, 06, 28, 8, 0, 0, 0), End_working = new DateTime(2017, 06, 28, 17, 0, 0, 0) };
            Site_Statistic s4 = new Site_Statistic() { ID_employee = 2, Datetime_of_record = new DateTime(2017, 06, 27, 9, 0, 0, 0), Start_working = new DateTime(2017, 06, 27, 9, 0, 0, 0), End_working = new DateTime(2017, 06, 27, 19, 0, 0, 0) };
            Site_Statistic s5 = new Site_Statistic() { ID_employee = 3, Datetime_of_record = new DateTime(2017, 06, 28, 9, 0, 0, 0), Start_working = new DateTime(2017, 06, 28, 9, 0, 0, 0), End_working = new DateTime(2017, 06, 28, 18, 0, 0, 0) };
            Site_Statistic s6 = new Site_Statistic() { ID_employee = 3, Datetime_of_record = new DateTime(2017, 06, 27, 9, 0, 0, 0), Start_working = new DateTime(2017, 06, 27, 9, 0, 0, 0), End_working = new DateTime(2017, 06, 27, 18, 0, 0, 0) };
            Site_Statistic s7 = new Site_Statistic() { ID_employee = 4, Datetime_of_record = new DateTime(2017, 06, 28, 8, 30, 0, 0), Start_working = new DateTime(2017, 06, 28, 8, 30, 0, 0), End_working = new DateTime(2017, 06, 28, 17, 0, 0, 0) };
            Site_Statistic s8 = new Site_Statistic() { ID_employee = 5, Datetime_of_record = new DateTime(2017, 06, 27, 8, 30, 0, 0), Start_working = new DateTime(2017, 06, 27, 8, 30, 0, 0), End_working = new DateTime(2017, 06, 27, 18, 0, 0, 0) };
            db.Site_Statistics.AddRange(new List<Site_Statistic> {s1,s2,s3,s4,s5,s6,s7,s8 });
            db.SaveChanges();



        }
    }
    }
