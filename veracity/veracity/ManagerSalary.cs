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
using veracity.DAL.Entities;

namespace veracity
{
    public partial class ManagerSalary : Form
    {
        private int department;

        public ManagerSalary(int dep)
        {
            department = dep;
            InitializeComponent();
        }

        private void ManagerSalary_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            if (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.Rows.Clear();
            }
            List<Employee> list = ManagerMethods.GetAllByDepartment(department);
            for (int i = 0; i < list.Count; i++)
            {
                
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = list[i].ID_employee;
                dataGridView1.Rows[i].Cells[1].Value = list[i].Name;
                dataGridView1.Rows[i].Cells[2].Value = list[i].Departments.ID;
                dataGridView1.Rows[i].Cells[3].Value = list[i].Salary;
                dataGridView1.Rows[i].Cells[4].Value = EmployeeMethods.GetTotalHours(list[i].ID_employee);
                dataGridView1.Rows[i].Cells[5].Value = EmployeeMethods.GetTotalPoints(list[i].ID_employee);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (true)
            {

            }
            ManagerMethods.ChangeSalary(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value), Convert.ToInt32(textBox1.Text));
            MessageBox.Show("Salary changed");
            RefreshForm();
           


        }
    }
}
