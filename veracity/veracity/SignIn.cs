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
using BLL;
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
            DataContext db = new DataContext();
            List<Site_Statistic> lst = new List<Site_Statistic>() { new Site_Statistic()  };
            List<Site_Statistic> lst1 = new List<Site_Statistic>() { new Site_Statistic() };
            List<Site_Statistic> lst2 = new List<Site_Statistic>() { new Site_Statistic() };
            DAL.Entities.Employee t = new DAL.Entities.Employee { ID_employee = 1, IsManager = false, Home_adress = "asdasd", Name = "ebalo", Phone_number = "02013321", Login="eblo", Password="bomjara", Site_Statistics = lst };
            DAL.Entities.Employee t1 = new DAL.Entities.Employee { ID_employee = 2, IsManager = false, Home_adress = "asdasd", Name = "ebalo", Phone_number = "02013321", Login = "ebl", Password = "bomjara", Site_Statistics = lst2 };
            DAL.Entities.Employee m = new DAL.Entities.Employee { ID_employee = 3, IsManager = true, Home_adress = "qweqe", Name = "oloolo", Phone_number = "02013321", Login = "man", Password = "man", Site_Statistics = lst1 };
            db.Employees.Add(t);
            db.Employees.Add(t1);
            db.Employees.Add(m);
            db.SaveChanges();
            DAL.Entities.Task task1 = new DAL.Entities.Task { ID_employee = 1, ID_task = 1, Status = "test st", Task_descr = "test descr" };
            DAL.Entities.Task task2 = new DAL.Entities.Task { ID_employee = 1, ID_task = 2, Status = "test st2", Task_descr = "test descr2" };
            db.Tasks.Add(task1);
            db.Tasks.Add(task2);
            db.SaveChanges();
            /*List<DAL.Entities.Employee> ls = db.Employees.ToList();
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
                //label1.Text = worker.ID_employee.ToString();
                if(worker != null)
                { 
                if ((worker.Password == password))
                {
                    if (worker.IsManager == false)
                    {
                        MessageBox.Show("Logged in as employee");
                        EmployeeForm f1 = new EmployeeForm(worker.ID_employee);
                        f1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Logged in as manager");
                        ManagerMain f1 = new ManagerMain(ManagerMethods.TransformEmplToDTO(worker));
                        f1.ShowDialog();
                    }
                }else
                {
                    MessageBox.Show("Wrong password");
                }
                }
                else MessageBox.Show("User not found");
            }
            /*if (e.KeyCode == Keys.M)
            {
                MessageBox.Show("Logged in by Manager");
                ManagerMain man = new ManagerMain();
                man.ShowDialog();
            }*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
