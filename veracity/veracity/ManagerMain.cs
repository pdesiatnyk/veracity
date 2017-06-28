using BLL.DTO;
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
    
    public partial class ManagerMain : Form
    {
        EmployeeDTO manager;
        public ManagerMain()
        {
            InitializeComponent();
        }

        private void BtnStatistic_Click(object sender, EventArgs e)
        {
           
            ManagerStatistic stat = new ManagerStatistic(manager.Department.ID);
            stat.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerConfirmTask confirm = new ManagerConfirmTask();
            confirm.ShowDialog();
        }

        private void BtnSalary_Click(object sender, EventArgs e)
        {
            ManagerSalary salary = new ManagerSalary();
            salary.ShowDialog();
        }

        private void BtnNewTask_Click(object sender, EventArgs e)
        {
            ManagerAddTask addtask = new ManagerAddTask();
            addtask.ShowDialog();
        }

        private void ManagerMain_Load(object sender, EventArgs e)
        {

        }
    }
}
