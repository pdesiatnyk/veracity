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
        public string Login;
        public string Password;
    }
}
