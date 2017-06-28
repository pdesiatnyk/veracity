using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using veracity.DAL.EF;
using BLL;

namespace veracity
{
    public partial class EmpTaskStatisticForm : Form
    {
        public int UserID;
        public EmpTaskStatisticForm()
        {
            InitializeComponent();
        }

        public EmpTaskStatisticForm(int id)
        {
            UserID = id;
            InitializeComponent();
        }

        private void EmpTaskStatisticForm_Load(object sender, EventArgs e)
        {
            List<DAL.Entities.Task> lst = EmployeeMethods.GetTaskStatistic(UserID);
            string userName = EmployeeMethods.GetUserNameById(UserID);
            dataGridView1.DataSource = lst;
            lblEmpName.Text = userName.ToString();
            dataGridView1.Columns[0].Name = "Task ID";
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Name = "Task Status";
            dataGridView1.Columns[3].Name = "Task Description";
            dataGridView1.Columns[3].Width = 250;
        }
    }
}
