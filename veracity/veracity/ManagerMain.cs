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
using veracity.DAL.Entities;

namespace veracity
{
    
    public partial class ManagerMain : Form
    {
        Department dep;
        public ManagerMain(Department dep)
        {
            this.dep = dep;
            InitializeComponent();
        }

        private void BtnStatistic_Click(object sender, EventArgs e)
        {

            ManagerStatistic stat = new ManagerStatistic(dep.ID);
            stat.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerConfirmTask confirm = new ManagerConfirmTask(dep.ID);
            confirm.ShowDialog();
        }

        private void BtnSalary_Click(object sender, EventArgs e)
        {
            ManagerSalary salary = new ManagerSalary(dep.ID);
            salary.ShowDialog();
        }

        private void BtnNewTask_Click(object sender, EventArgs e)
        {
            ManagerAddTask addtask = new ManagerAddTask(dep.ID);
            addtask.ShowDialog();
        }

        private void ManagerMain_Load(object sender, EventArgs e)
        {

        }
    }
}
