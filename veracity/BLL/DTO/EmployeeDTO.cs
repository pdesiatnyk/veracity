using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class EmployeeDTO
    {
        public int ID_employee { get; set; }
        public string Name { get; set; }
        public bool IsManager { get; set; }
        public int Salary { get; set; }
        public int Award { get; set; }


    }
}
