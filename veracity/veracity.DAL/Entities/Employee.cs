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
        public int ID_employee { get; set; }
        public string Name { get; set; }
        public string Home_adress { get; set; }
        public string Phone_number { get; set; }
        public int ID_role { get; set; }
 
    }
}
