using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void buttonUserDeleteReseravtion_Click(object sender, EventArgs e)
        {
            //http delete
        }

        private void buttonUserSeansList_Click(object sender, EventArgs e)
        {
            //http get
        }

        private void buttonReserveTickets_Click(object sender, EventArgs e)
        {
            
            decimal SeansID = numericUpDownUserSeansID.Value ;
            decimal ticketNumber = numericUpDownUserSeansID.Value;
            //http post
        }

        private void buttonUserMyReservations_Click(object sender, EventArgs e)
        {
            //http get
        }
    }
}
