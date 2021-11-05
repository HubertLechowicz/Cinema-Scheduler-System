
namespace WinFormsApp1
{
    partial class Worker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddSeans = new System.Windows.Forms.Button();
            this.textBoxMovieTitle = new System.Windows.Forms.TextBox();
            this.labelMovieTitle = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelRoom = new System.Windows.Forms.Label();
            this.dateTimePickerWorkerDatePick = new System.Windows.Forms.DateTimePicker();
            this.labelLenghth = new System.Windows.Forms.Label();
            this.numericUpDownWorkerLenghth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWorkerRoom = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewWorkerSeansList = new System.Windows.Forms.DataGridView();
            this.buttonWorkerSeansList = new System.Windows.Forms.Button();
            this.buttonWorkerDeleteSeans = new System.Windows.Forms.Button();
            this.numericUpDownWorkerSeansNr = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerWorkerTimePick = new System.Windows.Forms.DateTimePicker();
            this.labelTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkerLenghth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkerRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkerSeansList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkerSeansNr)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddSeans
            // 
            this.buttonAddSeans.Location = new System.Drawing.Point(91, 283);
            this.buttonAddSeans.Name = "buttonAddSeans";
            this.buttonAddSeans.Size = new System.Drawing.Size(161, 32);
            this.buttonAddSeans.TabIndex = 0;
            this.buttonAddSeans.Text = "Dodaj Seans";
            this.buttonAddSeans.UseVisualStyleBackColor = true;
            this.buttonAddSeans.Click += new System.EventHandler(this.buttonAddSeans_Click);
            // 
            // textBoxMovieTitle
            // 
            this.textBoxMovieTitle.Location = new System.Drawing.Point(152, 115);
            this.textBoxMovieTitle.Name = "textBoxMovieTitle";
            this.textBoxMovieTitle.Size = new System.Drawing.Size(209, 23);
            this.textBoxMovieTitle.TabIndex = 1;
            // 
            // labelMovieTitle
            // 
            this.labelMovieTitle.AutoSize = true;
            this.labelMovieTitle.Location = new System.Drawing.Point(27, 115);
            this.labelMovieTitle.Name = "labelMovieTitle";
            this.labelMovieTitle.Size = new System.Drawing.Size(65, 15);
            this.labelMovieTitle.TabIndex = 2;
            this.labelMovieTitle.Text = "Tytuł Filmu";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(31, 144);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(31, 15);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Data";
            this.labelDate.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(31, 202);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(28, 15);
            this.labelRoom.TabIndex = 4;
            this.labelRoom.Text = "Sala";
            this.labelRoom.Click += new System.EventHandler(this.labelRoom_Click);
            // 
            // dateTimePickerWorkerDatePick
            // 
            this.dateTimePickerWorkerDatePick.Location = new System.Drawing.Point(152, 144);
            this.dateTimePickerWorkerDatePick.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerWorkerDatePick.Name = "dateTimePickerWorkerDatePick";
            this.dateTimePickerWorkerDatePick.Size = new System.Drawing.Size(209, 23);
            this.dateTimePickerWorkerDatePick.TabIndex = 5;
            // 
            // labelLenghth
            // 
            this.labelLenghth.AutoSize = true;
            this.labelLenghth.Location = new System.Drawing.Point(31, 231);
            this.labelLenghth.Name = "labelLenghth";
            this.labelLenghth.Size = new System.Drawing.Size(93, 15);
            this.labelLenghth.TabIndex = 6;
            this.labelLenghth.Text = "Długość Trwania";
            // 
            // numericUpDownWorkerLenghth
            // 
            this.numericUpDownWorkerLenghth.Location = new System.Drawing.Point(152, 231);
            this.numericUpDownWorkerLenghth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWorkerLenghth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWorkerLenghth.Name = "numericUpDownWorkerLenghth";
            this.numericUpDownWorkerLenghth.Size = new System.Drawing.Size(209, 23);
            this.numericUpDownWorkerLenghth.TabIndex = 9;
            this.numericUpDownWorkerLenghth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownWorkerRoom
            // 
            this.numericUpDownWorkerRoom.Location = new System.Drawing.Point(152, 202);
            this.numericUpDownWorkerRoom.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownWorkerRoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWorkerRoom.Name = "numericUpDownWorkerRoom";
            this.numericUpDownWorkerRoom.Size = new System.Drawing.Size(209, 23);
            this.numericUpDownWorkerRoom.TabIndex = 10;
            this.numericUpDownWorkerRoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dataGridViewWorkerSeansList
            // 
            this.dataGridViewWorkerSeansList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkerSeansList.Location = new System.Drawing.Point(439, 80);
            this.dataGridViewWorkerSeansList.Name = "dataGridViewWorkerSeansList";
            this.dataGridViewWorkerSeansList.RowTemplate.Height = 25;
            this.dataGridViewWorkerSeansList.Size = new System.Drawing.Size(454, 262);
            this.dataGridViewWorkerSeansList.TabIndex = 11;
            // 
            // buttonWorkerSeansList
            // 
            this.buttonWorkerSeansList.Location = new System.Drawing.Point(603, 51);
            this.buttonWorkerSeansList.Name = "buttonWorkerSeansList";
            this.buttonWorkerSeansList.Size = new System.Drawing.Size(129, 23);
            this.buttonWorkerSeansList.TabIndex = 12;
            this.buttonWorkerSeansList.Text = "Pobierz Seanse";
            this.buttonWorkerSeansList.UseVisualStyleBackColor = true;
            this.buttonWorkerSeansList.Click += new System.EventHandler(this.buttonWorkerSeansList_Click);
            // 
            // buttonWorkerDeleteSeans
            // 
            this.buttonWorkerDeleteSeans.Location = new System.Drawing.Point(603, 348);
            this.buttonWorkerDeleteSeans.Name = "buttonWorkerDeleteSeans";
            this.buttonWorkerDeleteSeans.Size = new System.Drawing.Size(105, 23);
            this.buttonWorkerDeleteSeans.TabIndex = 13;
            this.buttonWorkerDeleteSeans.Text = "Usuń Seans nr";
            this.buttonWorkerDeleteSeans.UseVisualStyleBackColor = true;
            this.buttonWorkerDeleteSeans.Click += new System.EventHandler(this.buttonWorkerDeleteSeans_Click);
            // 
            // numericUpDownWorkerSeansNr
            // 
            this.numericUpDownWorkerSeansNr.Location = new System.Drawing.Point(714, 348);
            this.numericUpDownWorkerSeansNr.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWorkerSeansNr.Name = "numericUpDownWorkerSeansNr";
            this.numericUpDownWorkerSeansNr.Size = new System.Drawing.Size(50, 23);
            this.numericUpDownWorkerSeansNr.TabIndex = 14;
            this.numericUpDownWorkerSeansNr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePickerWorkerTimePick
            // 
            this.dateTimePickerWorkerTimePick.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerWorkerTimePick.Location = new System.Drawing.Point(152, 173);
            this.dateTimePickerWorkerTimePick.Name = "dateTimePickerWorkerTimePick";
            this.dateTimePickerWorkerTimePick.Size = new System.Drawing.Size(209, 23);
            this.dateTimePickerWorkerTimePick.TabIndex = 15;
            this.dateTimePickerWorkerTimePick.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged_1);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(31, 173);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(31, 15);
            this.labelTime.TabIndex = 16;
            this.labelTime.Text = "Czas";
            // 
            // Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 392);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.dateTimePickerWorkerTimePick);
            this.Controls.Add(this.numericUpDownWorkerSeansNr);
            this.Controls.Add(this.buttonWorkerDeleteSeans);
            this.Controls.Add(this.buttonWorkerSeansList);
            this.Controls.Add(this.dataGridViewWorkerSeansList);
            this.Controls.Add(this.numericUpDownWorkerRoom);
            this.Controls.Add(this.numericUpDownWorkerLenghth);
            this.Controls.Add(this.labelLenghth);
            this.Controls.Add(this.dateTimePickerWorkerDatePick);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelMovieTitle);
            this.Controls.Add(this.textBoxMovieTitle);
            this.Controls.Add(this.buttonAddSeans);
            this.Name = "Worker";
            this.Text = "Worker";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkerLenghth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkerRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkerSeansList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkerSeansNr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddSeans;
        private System.Windows.Forms.TextBox textBoxMovieTitle;
        private System.Windows.Forms.Label labelMovieTitle;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.DateTimePicker dateTimePickerWorkerDatePick;
        private System.Windows.Forms.Label labelLenghth;
        private System.Windows.Forms.NumericUpDown numericUpDownWorkerLenghth;
        private System.Windows.Forms.NumericUpDown numericUpDownWorkerRoom;
        private System.Windows.Forms.DataGridView dataGridViewWorkerSeansList;
        private System.Windows.Forms.Button buttonWorkerSeansList;
        private System.Windows.Forms.Button buttonWorkerDeleteSeans;
        private System.Windows.Forms.NumericUpDown numericUpDownWorkerSeansNr;
        private System.Windows.Forms.DateTimePicker dateTimePickerWorkerTimePick;
        private System.Windows.Forms.Label labelTime;
    }
}