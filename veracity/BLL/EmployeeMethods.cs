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
        public static List<veracity.DAL.Entities.Task> GetUsersTasks(int id)
        {
            List<veracity.DAL.Entities.Task> lst = new List<veracity.DAL.Entities.Task>();
            DataContext db = new DataContext();

            lst = (from p in db.Tasks
                   where p.ID_employee == id
                   where p.Status=="in progress"
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
                   where p.ID_employee == id
                   select p).ToList();
            return lst;

        }
        public static int GetTotalHours(int id)
        {
            int result = 0;
            List<Site_Statistic> lst = GetTimeStatistic(id);

            foreach (var r in lst)
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
        public static int GetTotalPoints(int id)
        {
            int result = 0;

            List<Achievement> lst = new List<Achievement>();
            DataContext db = new DataContext();

            lst = (from p in db.Achievements
                   where p.Tasks.ID_employee == id
                   select p).ToList();

            foreach (var p in lst)
            {
                result += Convert.ToInt32(p.Achievement_points);
            }
            return result;
        }
        public static double GetSalary(double time)
        {
            return time * 25;
        }

        public static void SubmitTask(int id)
        {
            veracity.DAL.Entities.Task lst = new veracity.DAL.Entities.Task();
            DataContext db = new DataContext();

            lst = (from p in db.Tasks
                   where p.ID_task == id
                   select p).FirstOrDefault();
            lst.Status = "Waiting for acceptance";
            db.SaveChanges();

        }

        
    }
}
