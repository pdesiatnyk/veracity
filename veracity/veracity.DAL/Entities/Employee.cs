using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veracity.DAL.Entities
{
   public class Employee: User
    {
        [Key]
       // public int ID_employee { get; set; }
        public string Name { get; set; }
        public string Home_adress { get; set; }
        public string Phone_number { get; set; }
        public bool IsManager { get; set; }
        public int Salary { get; set; }
        public int Award { get; set; }
        public int Points { get; set; }
        public ICollection<Achievement> Achievements {get; set;}
        public ICollection<Task> Tasks { get; set; }
        public ICollection<Site_Statistic> Site_Statistics { get; set; }
        public Department Departments { get; set; }
    }
}
