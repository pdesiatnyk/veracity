using BLL;
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
    public partial class EmpProjectedSalaryForm : Form
    {
        public int UserID;
        public EmpProjectedSalaryForm()
        {
            InitializeComponent();
        }
        public EmpProjectedSalaryForm(int id)
        {
            UserID = id;
            InitializeComponent();
        }

        private void EmpProjectedSalaryForm_Load(object sender, EventArgs e)
        {
            label6.Text = EmployeeMethods.GetUserNameById(UserID);
            int hours = EmployeeMethods.GetTotalHours(UserID);
            int minutes = EmployeeMethods.GetTotalMinutes(UserID);
            double time = hours * 60 + minutes;
            time /= 60;
            label8.Text = time.ToString();
            label9.Text = EmployeeMethods.GetTotalPoints(UserID).ToString();
            label10.Text = EmployeeMethods.GetSalary(time).ToString();

        }
    }
}
