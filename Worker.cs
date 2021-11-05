using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Worker : Form
    {
        public Worker()
        {
            InitializeComponent();
        }


        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void labelRoom_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonAddSeans_Click(object sender, EventArgs e)
        {
            if (textBoxMovieTitle.Text == "" )
            {
                MessageBox.Show("Podaj tytuł filmu");
                return;
            }

            string Title = textBoxMovieTitle.Text;
            DateTime datetime = dateTimePickerWorkerDatePick.Value.Date + dateTimePickerWorkerTimePick.Value.TimeOfDay;
            decimal MovieLenghth = numericUpDownWorkerRoom.Value;
            decimal Room = numericUpDownWorkerLenghth.Value;

            //httpp post

        }


        private void buttonWorkerDeleteSeans_Click(object sender, EventArgs e)
        {
            decimal SeansID = numericUpDownWorkerSeansNr.Value;
            //http delete
        }

        private void buttonWorkerSeansList_Click(object sender, EventArgs e)
        {
            //http get 
        }
    }
}
