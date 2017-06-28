using BLL;
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
    public partial class ManagerAddTask : Form
    {
        int dep;
        public ManagerAddTask(int dep)
        {
            this.dep = dep;
            InitializeComponent();
        }

        private void ManagerAddTask_Load(object sender, EventArgs e)
        {
            List<Employee> list = ManagerMethods.GetAllByDepartment(dep);
            foreach (var item in list)
            {
                
                comboBox1.Items.Add(item.Name);
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerMethods.AddTask(textBox1.Text, comboBox1.SelectedItem.ToString());
        }
    }
}
