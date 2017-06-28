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
    public partial class ManagerConfirmTask : Form
    { int dep;
        public ManagerConfirmTask(int dep)
        {
            this.dep = dep;
            InitializeComponent();
        }

        private void ManagerConfirmTask_Load(object sender, EventArgs e)
        {
            List<DAL.Entities.Task> list = ManagerMethods.GetUnconfTasks(dep);
            foreach (var item in list)
            {
                MessageBox.Show(item.Task_descr);
            }

        }
    }
}
