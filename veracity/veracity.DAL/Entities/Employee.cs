using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veracity.DAL.Entities
{
   public class Employee: User
    {
        public int ID_employee { get; set; }
        public string Name { get; set; }
        public string Home_adress { get; set; }
        public string Phone_number { get; set; }
        public int ID_role { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public ICollection<Achievement> Achievements { get; set; }
        public ICollection<Site_Statistic> Site_statistics { get; set; }
    }
}
