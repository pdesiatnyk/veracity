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
    public partial class EmpTimeStatisticForm : Form
    {
        public int UserID;
        public EmpTimeStatisticForm()
        {
            InitializeComponent();
        }
        public EmpTimeStatisticForm(int id)
        {
            UserID = id;
            InitializeComponent();
        }

        private void EmpTimeStatisticForm_Load(object sender, EventArgs e)
        {
            List<Site_Statistic> lst = EmployeeMethods.GetTimeStatistic(UserID);
            int hours = EmployeeMethods.GetTotalHours(UserID);
            int minutes = EmployeeMethods.GetTotalMinutes(UserID);
            double time = hours * 60 + minutes;
            time /= 60;
            double m2 = time - (int)time;
            m2 *= 60;
            double h = Math.Truncate(time);
            string userName = EmployeeMethods.GetUserNameById(UserID);
            label2.Text = userName;
            label4.Text = h.ToString()+" hours "+m2.ToString()+" minutes";
            dataGridView1.DataSource = lst;

            dataGridView1.Columns[0].Name = "Record ID";
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Name = "Date of Record";
            dataGridView1.Columns[3].Name = "End working";
            dataGridView1.Columns[4].Name = "Start working";
        }
    }
}
