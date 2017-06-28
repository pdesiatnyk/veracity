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
    public partial class EmpSendTaskForm : Form
    {
        public int UserID;
        public EmpSendTaskForm()
        {
            InitializeComponent();
        }
        public EmpSendTaskForm(int id)
        {
            UserID = id;
            InitializeComponent();
        }

        private void EmpSendTaskForm_Load(object sender, EventArgs e)
        {
            List<DAL.Entities.Task> lst = EmployeeMethods.GetUsersTasks(UserID);
            string userName = EmployeeMethods.GetUserNameById(UserID);
            foreach(var t in lst)
            {
                comboBox1.Items.Add(t.ID_task);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeMethods.SubmitTask(Convert.ToInt32(comboBox1.SelectedItem));
            MessageBox.Show("task submitted");
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            comboBox1.Text= "";
        }
    }
}
