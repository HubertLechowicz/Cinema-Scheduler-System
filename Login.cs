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
                MessageBox.Show("Podaj proszę email i hasło!");
                return;
            }
            try
            {
                //SQL connection here
  

                string type = "worker";
                switch (type)
                {
                    case "admin":
                        MessageBox.Show("Zalogowano jako Admin Pomyślnie!");
                        this.Hide();
                        Admin adminForm = new Admin();
                        adminForm.Show();
                        break;

                    case "user":
                        MessageBox.Show("Zalogowano Użytkownika Pomyślnie!!");
                        this.Hide();
                        User userForm = new User();
                        userForm.Show();
                        break;

                    case "worker":
                        MessageBox.Show("Zalogowano Pracownika Pomyślnie!!");
                        this.Hide();
                        Worker workerForm = new Worker();
                        workerForm.Show();
                        break;

                    default:
                        MessageBox.Show("Logowanie Nieudane!");
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
