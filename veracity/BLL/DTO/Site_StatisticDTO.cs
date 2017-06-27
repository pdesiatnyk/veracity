using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
   public class Site_StatisticDTO
    {
        public int ID_record { get; set; }
        public DateTime? Datetime_of_record { get; set; }
        public DateTime? End_working { get; set; }
        public DateTime? Start_working { get; set; }
    }
}
