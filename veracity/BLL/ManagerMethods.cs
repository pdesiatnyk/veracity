using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veracity.DAL.Entities;
using veracity.DAL.Repositories;

namespace BLL
{
    public static class ManagerMethods
    {

        public static List<EmployeeDTO> GetAllByDepartment(int depId) {
            List<EmployeeDTO> returnlist = new List<EmployeeDTO>();
            EmployeeRepository rep = new EmployeeRepository();
            IEnumerable<Employee> emplall = rep.GetAll();

            foreach (Employee item in emplall)
            {
                EmployeeDTO dto = new EmployeeDTO();
                dto.Department.ID = item.Departments.ID;
                dto.Department.Name = item.Departments.Name;
                dto.Name = item.Name;
                dto.Points = item.Points;
                foreach (Site_Statistic stat in item.Site_Statistics)
                {
                    Site_StatisticDTO statadto = new Site_StatisticDTO();
                    statadto.ID_record = stat.ID_record;
                    statadto.Start_working = stat.Start_working;
                    statadto.End_working= stat.End_working;

                    dto.Site_Statistics.Add(statadto);
                }
                returnlist.Add(dto);
              
            }
            foreach (var item in returnlist)
            {
                if (item.Department.ID!=depId && item.IsManager==false)
                {
                    returnlist.Remove(item);
                }
            }

            return returnlist;

        }

        public static double CalculateTime(EmployeeDTO emp)
        {

            return 1;
        }



    }
}
