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
            List<Site_Statistic> lst = new List<Site_Statistic>() { new Site_Statistic() };
            DAL.Entities.Employee t = new DAL.Entities.Employee { ID_employee = 1, IsManager = false, Home_adress = "asdasd", Name = "ebalo", Phone_number = "02013321", Login="eblo", Password="bomjara", Site_Statistics = lst };
            db.Employees.Add(t);

            db.SaveChanges();
            List<DAL.Entities.Employee> ls = db.Employees.ToList();
            foreach (var k in ls)
            {
                MessageBox.Show(k.Login);
            }
        }
    }
}
