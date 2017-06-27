using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veracity.DAL.Entities
{
    public class User
    {
        [Key]
        
        public int ID_employee { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
