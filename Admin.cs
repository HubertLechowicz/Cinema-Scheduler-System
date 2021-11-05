using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;

using System.Linq;

using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    

    public partial class Admin : Form
    {
        public Admin()
        {
          

            InitializeComponent();

        }

        
        

        private void listView2_Click(object sender, EventArgs e)
        {
            var firstSelectedItem = listView2.SelectedItems[0];
            firstSelectedItem.SubItems[1].Text = "Pobrane Passy z Bazy";
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //var cities = new List<string>();
           // cities.Add("New York");
             //cities.Add("London");
           // dataGridView1.DataSource = cities; // MyList is a List<string>

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:3000/");
                //HTTP GET
                var responseTask = client.GetAsync("users");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    
                    var readTask = result.Content.ReadAsStringAsync(); // ReadAsAsync<UsersList[]>();
                    readTask.Wait();

                    var userlist = readTask.Result;
                    Console.WriteLine(userlist);
                    dataGridView1.DataSource = userlist;

                   
                }
            }

        }
    }
}