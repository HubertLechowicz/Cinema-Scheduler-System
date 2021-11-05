using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //Connection String
            private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Please provide email and password");
                return;
            }
            try
            {
                //SQL connection here
  

                string type = "admin";
                switch (type)
                {
                    case "admin":
                        MessageBox.Show("Admin Login Successful!");
                        this.Hide();
                        Admin adminForm = new Admin();
                        adminForm.Show();
                        break;

                    case "user":
                        MessageBox.Show("User Login Successful!");
                        this.Hide();
                        Admin userForm = new Admin();
                        userForm.Show();
                        break;

                    case "worker":
                        MessageBox.Show("Worker Login Successful!");
                        this.Hide();
                        Admin workerForm = new Admin();
                        workerForm.Show();
                        break;

                    default:
                        MessageBox.Show("Login Failed!");
                        break;
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
