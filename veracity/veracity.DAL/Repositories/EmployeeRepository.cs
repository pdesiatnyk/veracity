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
     public class EmployeeRepository : IRepository<Employee>
    {
        private DataContext db;
        public EmployeeRepository ()
        {
            
            this.db = new DataContext(); ;
        }
        public IEnumerable<Employee> GetAll()
        {
            return db.Employees;
        }
        public Employee Get(int id)
        {
            return db.Employees.Find(id);
        }
        public void Create(Employee worker)
        {
            db.Employees.Add(worker);
        }
        public void Update(Employee worker)
        {
            db.Entry(worker).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete (int id)
        {
            Employee worker = db.Employees.Find(id);
            if(worker!=null)
            {
                db.Employees.Remove(worker);
            }
        }

        public IEnumerable<Employee> Find(Func<Employee, Boolean> predicate)
        {
            return db.Employees.Where(predicate).ToList();
        }
    }
}
