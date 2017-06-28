using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veracity.DAL.EF;
using veracity.DAL.Entities;
using veracity.DAL.Repositories;

namespace BLL
{
    public static class ManagerMethods
    {

        public static List<Employee> GetAllByDepartment(int depId) {
            DataContext db = new DataContext();
            List<Employee> ret = db.Employees.Where(x => x.Departments.ID == depId && x.IsManager==false).ToList();


            //List <EmployeeDTO> returnlist = new List<EmployeeDTO>();
            //EmployeeRepository rep = new EmployeeRepository();
            //IEnumerable<Employee> emplall = rep.GetAll();

            //foreach (Employee item in emplall)
            //{
                
            //    returnlist.Add(TransformEmplToDTO(item));
              
            //}
            //foreach (var item in returnlist)
            //{
            //    if (item.Department.ID!=depId && item.IsManager==false)
            //    {
            //        returnlist.Remove(item);
            //    }
            //}

            //   return returnlist;
            return ret;

        }

        public static void ConfirmTask(int id, string points)
        {

            DataContext db = new DataContext();
            veracity.DAL.Entities.Task tsk = db.Tasks.Find(id);
            Achievement ach = new Achievement() { Achievement_points=points, ID_task=id , Tasks=tsk};
            db.Achievements.Add(ach);
            tsk.Status = "Done";
            db.SaveChanges();
        }

        public static void ChangeSalary(int idempl, int award)
        {
            DataContext db = new DataContext();
            Employee emp = db.Employees.Find(idempl);
            double totalhrs = Convert.ToDouble(EmployeeMethods.GetTotalHours(emp.ID_employee));
            emp.Salary = EmployeeMethods.GetSalary(totalhrs)+award;
            db.SaveChanges();


        }

        public static Employee FindEmplById(int id)
        {
            DataContext db = new DataContext();
            return db.Employees.Find(id);

        }

        public static List<veracity.DAL.Entities.Task> GetUnconfTasks(int dep)
        {
            List<veracity.DAL.Entities.Task> list=new List<veracity.DAL.Entities.Task>();
            List<Employee> empl = ManagerMethods.GetAllByDepartment(dep);
            foreach (var item in empl)
            {
                List<veracity.DAL.Entities.Task> tsks = EmployeeMethods.GetTaskStatistic(item.ID_employee);
                foreach (var task in tsks)
                {
                    if (task.Status=="Waiting for acceptance")
                    {
                        list.Add(task);
                    }
                }

            }

            
            return list;
            
        }

       

        public static void AddTask(string text, string v)
        {
            DataContext db = new DataContext();
            Employee emp = db.Employees.Where(x => x.Name == v).FirstOrDefault();
            int id = emp.ID_employee;
            veracity.DAL.Entities.Task task = new veracity.DAL.Entities.Task() {ID_employee=id, Task_descr=text, Status="In progress" };
            db.Tasks.Add(task);
            db.SaveChanges();

        }

        public static EmployeeDTO TransformEmplToDTO(Employee item)
        {

            EmployeeDTO dto = new EmployeeDTO();
            //dto.Department.ID = item.Departments.ID;
            //dto.Department.Name = item.Departments.Name;
            dto.Name = item.Name;
            dto.Points = item.Points;
            foreach (Site_Statistic stat in item.Site_Statistics)
            {
                Site_StatisticDTO statadto = new Site_StatisticDTO();
                statadto.ID_record = stat.ID_record;
                statadto.Start_working = stat.Start_working;
                statadto.End_working = stat.End_working;

                dto.Site_Statistics.Add(statadto);
            }
            return dto;
        }

        public static double CalculateTime(EmployeeDTO emp)
        {

            return 1;
        }



    }
}
