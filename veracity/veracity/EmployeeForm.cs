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
        public int UserID;
        public EmployeeForm()
        {
            InitializeComponent();
        }
        public EmployeeForm(int id)
        {
            UserID = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //abel1.Text = UserID.ToString();
            EmpTaskStatisticForm f1 = new EmpTaskStatisticForm(UserID);
            f1.ShowDialog();
        }

        private void BtnEmpTimeStatictic_Click(object sender, EventArgs e)
        {
            EmpTimeStatisticForm f1 = new EmpTimeStatisticForm(UserID);
            f1.ShowDialog();
        }

        private void BtnEmpProjectedSalary_Click(object sender, EventArgs e)
        {
            EmpProjectedSalaryForm f1 = new EmpProjectedSalaryForm(UserID);
            f1.ShowDialog();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EmpSendTaskForm f1 = new EmpSendTaskForm(UserID);
            f1.ShowDialog();
        }
    }
}
