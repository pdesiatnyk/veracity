﻿using BLL.DTO;
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
            db.Configuration.ProxyCreationEnabled = true;
            db.Configuration.LazyLoadingEnabled = true;
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
