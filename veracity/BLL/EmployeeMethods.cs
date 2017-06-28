using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veracity.DAL.EF;
using veracity.DAL.Entities;

namespace BLL
{
    public static class EmployeeMethods
    {
        public static List<veracity.DAL.Entities.Task> GetTaskStatistic(int id)
        {
            List<veracity.DAL.Entities.Task> lst = new List<veracity.DAL.Entities.Task>();
            DataContext db = new DataContext();

            lst = (from p in db.Tasks
                  where p.ID_employee == id
                  select p).ToList();
            return lst;

        }
        public static string GetUserNameById(int id)
        {
            DataContext db = new DataContext();
            Employee emp = new Employee();
            emp = (from p in db.Employees where p.ID_employee == id select p).FirstOrDefault();
            return emp.Name;
        }

    }
}
