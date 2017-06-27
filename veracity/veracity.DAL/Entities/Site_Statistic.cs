using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veracity.DAL.Entities
{
   public class Site_Statistic
    {
        [Key]
        public int ID_record { get; set; }
        public DateTime Datetime_of_record { get; set; }
        public DateTime Start_working { get; set; }
        public DateTime End_working { get; set; }
        public int ID_employee { get; set; }
    }
}
