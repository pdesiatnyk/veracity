using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veracity.DAL.Interfaces;
using veracity.DAL;
using veracity.DAL.EF;
using veracity.DAL.Entities;

namespace veracity.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private DataContext db;
        private EmployeeRepository employeeRepository;
        private TaskRepository taskRepository;
        private AchievementRepository achievementRepository;
        private Site_StatisticRepository site_statisticRepository;
        private DepartmentRepository departmentRepository;
        public EFUnitOfWork()
        {
            db = new DataContext();
        }
        public IRepository<Employee> Employees
        {
            get
            {
                if (employeeRepository == null)
                    employeeRepository = new EmployeeRepository();
                return employeeRepository;
            }
        }

        public IRepository<Entities.Task> Tasks
        {
            get
            {
                if (taskRepository == null)
                    taskRepository = new TaskRepository(db);
                return taskRepository;
            }
        }

        public IRepository<Achievement> Achievements
        {
            get
            {
                if (achievementRepository == null)
                    achievementRepository = new AchievementRepository(db);
                return achievementRepository;
            }
        }
        public IRepository<Site_Statistic> Site_Statistics
        {
            get
            {
                if (site_statisticRepository == null)
                    site_statisticRepository = new Site_StatisticRepository(db);
                return site_statisticRepository;
            }
        }

        public IRepository<Department> Departments
        {
            get
            {
                if (departmentRepository == null)
                    departmentRepository = new DepartmentRepository(db);
                return departmentRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
