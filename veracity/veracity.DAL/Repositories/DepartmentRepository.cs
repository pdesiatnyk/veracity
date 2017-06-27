using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veracity.DAL.EF;
using veracity.DAL.Entities;
using veracity.DAL.Interfaces;

namespace veracity.DAL.Repositories
{
    public class DepartmentRepository : IRepository<Department>
    {
        private DataContext db;
        public DepartmentRepository(DataContext context)
        {
            this.db = context;
        }
        public IEnumerable<Department> GetAll()
        {
            return db.Departments;
        }
        public Department Get(int id)
        {
            return db.Departments.Find(id);
        }
        public void Create(Department worker)
        {
            db.Departments.Add(worker);
        }
        public void Update(Department worker)
        {
            db.Entry(worker).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            Department worker = db.Departments.Find(id);
            if (worker != null)
            {
                db.Departments.Remove(worker);
            }
        }

        public IEnumerable<Department> Find(Func<Department, Boolean> predicate)
        {
            return db.Departments.Where(predicate).ToList();
        }
    }
}
