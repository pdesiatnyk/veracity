using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veracity.DAL.Entities
{
   public class Task
    {
        [Key]
        public int ID_task { get; set; }
        public int ID_employee { get; set; }
        public string Status { get; set; }
        public string Task_descr { get; set; }

 
       // public Achievement Achievements { get; set; }
    }
}
