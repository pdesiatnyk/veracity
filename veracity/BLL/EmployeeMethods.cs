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

        public static List<Site_Statistic> GetTimeStatistic(int id)
        {
            List<Site_Statistic> lst = new List<Site_Statistic>();
            DataContext db = new DataContext();

            lst = (from p in db.Site_Statistics
                   where  p.ID_employee==id
                   select p).ToList();
            return lst;

        }
        public static int GetTotalHours(int id)
        {
            int result=0;
            List<Site_Statistic> lst = GetTimeStatistic(id);

            foreach(var r in lst)
            {
                result += (r.End_working.Value.Hour - r.Start_working.Value.Hour);
            }

            return result;
        }
        public static int GetTotalMinutes(int id)
        {
            int result = 0;
            List<Site_Statistic> lst = GetTimeStatistic(id);

            foreach (var r in lst)
            {
                result += (r.End_working.Value.Minute - r.Start_working.Value.Minute);
            }

            return result;
        }
    }
}
