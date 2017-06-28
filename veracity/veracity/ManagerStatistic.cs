using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.DTO;
using BLL;
using veracity.DAL.Entities;

namespace veracity
{
    public partial class ManagerStatistic : Form
    {
        private int department;

        //public ManagerStatistic()
        //{
        //    InitializeComponent();
        //}

        public ManagerStatistic(int department)
        {
            InitializeComponent();
            this.department = department;
        }

        private void ManagerStatistic_Load(object sender, EventArgs e)
        {
           List<Employee> list =  ManagerMethods.GetAllByDepartment(department);
            for (int i = 0; i < list.Count; i++)
            {
                
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = list[i].ID_employee;
                dataGridView1.Rows[i].Cells[1].Value = list[i].Name;
                dataGridView1.Rows[i].Cells[2].Value = list[i].Departments.ID;
                dataGridView1.Rows[i].Cells[3].Value =EmployeeMethods.GetTotalHours(list[i].ID_employee);
                dataGridView1.Rows[i].Cells[4].Value = EmployeeMethods.GetTotalPoints(list[i].ID_employee);

            }
           
        }
    }
}
