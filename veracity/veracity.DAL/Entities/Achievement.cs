using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veracity.DAL.Entities
{
    public class Achievement
    {
        [Key]
        public int ID_record { get; set; }

        public int ID_task { get; set; }
        public string Achievement_points { get; set; }
        public string Comment { get; set; }

       // public Task Tasks { get; set; }
    }
}