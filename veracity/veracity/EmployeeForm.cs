using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veracity
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpTaskStatisticForm f1 = new EmpTaskStatisticForm();
            f1.ShowDialog();
        }

        private void BtnEmpTimeStatictic_Click(object sender, EventArgs e)
        {
            EmpTimeStatisticForm f1 = new EmpTimeStatisticForm();
            f1.ShowDialog();
        }

        private void BtnEmpProjectedSalary_Click(object sender, EventArgs e)
        {
            EmpProjectedSalaryForm f1 = new EmpProjectedSalaryForm();
            f1.ShowDialog();
        }
    }
}
