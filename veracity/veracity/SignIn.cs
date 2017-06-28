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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*DataContext db = new DataContext();
            List<Site_Statistic> lst = new List<Site_Statistic>() { new Site_Statistic() };
            DAL.Entities.Employee t = new DAL.Entities.Employee { ID_employee = 1, IsManager = false, Home_adress = "asdasd", Name = "ebalo", Phone_number = "02013321", Login="eblo", Password="bomjara", Site_Statistics = lst };
            db.Employees.Add(t);

            db.SaveChanges();
            List<DAL.Entities.Employee> ls = db.Employees.ToList();
            foreach (var k in ls)
            {
                MessageBox.Show(k.Login);
            }*/
           
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                string login = textBox1.Text;
                string password = textBox2.Text;
                DataContext db = new DataContext();
                Employee worker = db.Employees.Where(p => p.Login == login).FirstOrDefault();
                if(worker != null)
                { 
                if ((worker.Password == password))
                {
                    if (worker.IsManager == false)
                    {
                        MessageBox.Show("Logged in as employee");
                        EmployeeForm f1 = new EmployeeForm();
                        f1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Logged in as manager");
                        ManagerMain f1 = new ManagerMain();
                        f1.ShowDialog();
                    }
                }else
                {
                    MessageBox.Show("Wrong password");
                }
                }
                else MessageBox.Show("User not found");
            }
            if (e.KeyCode == Keys.M)
            {
                MessageBox.Show("Logged in by Manager");
                ManagerMain man = new ManagerMain();
                man.ShowDialog();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
