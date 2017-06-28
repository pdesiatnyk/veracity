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
    public partial class ManagerConfirmTask : Form
    { int dep;
        public ManagerConfirmTask(int dep)
        {
            this.dep = dep;
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            ManagerMethods.ConfirmTask(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value),textBox1.Text);
            MessageBox.Show("Task confirmed!");
            RefreshForm();
            
        }
        private void ManagerConfirmTask_Load(object sender, EventArgs e)
    {

            RefreshForm();

        }
        private void RefreshForm()
        {
            if (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.Rows.Clear();
            }
            List<DAL.Entities.Task> list = ManagerMethods.GetUnconfTasks(dep);
            for (int i = 0; i < list.Count; i++)
            {

                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = list[i].ID_task;
                dataGridView1.Rows[i].Cells[1].Value = EmployeeMethods.GetUserNameById(list[i].ID_employee);
                dataGridView1.Rows[i].Cells[2].Value = list[i].Task_descr;
                dataGridView1.Rows[i].Cells[3].Value = list[i].Status;
               

            }
        }

        //private void ManagerConfirmTask_Load(object sender, EventArgs e)
        //{

        //}
    }
}
