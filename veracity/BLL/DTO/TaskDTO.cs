using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class TaskDTO
    {
        public int ID_task { get; set; }
        public int ID_employee { get; set; }
        public string Status { get; set; }
        public string Task_descr { get; set; }


        public AchievementDTO Achievements { get; set; }
    }
}
