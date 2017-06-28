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
            List<DAL.Entities.Task> lst = EmployeeMethods.GetTaskStatistic(1);
            dataGridView1.DataSource = lst;
            
        }
    }
}
