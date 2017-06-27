using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class AchievementDTO
    {
        public int ID_record { get; set; }

        public int ID_task { get; set; }
        public string Achievement_points { get; set; }
        public string Comment { get; set; }
    }
}
