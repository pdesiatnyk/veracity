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
using veracity.DAL.Entities;
using veracity.DAL.Interfaces;
using veracity.DAL.Repositories;

namespace veracity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataContext db = new DataContext();
            Employee t = new Employee { ID_employee = 1, ID_role = 1, Home_adress = "asdasd", Name = "ebalo", Phone_number = "02013321" };
            db.Employees.Add(t);
            db.SaveChanges();
            MessageBox.Show("asfas");
        }
    }
}
