
namespace WinFormsApp1
{
    partial class User
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
            this.dataGridViewUserSeansList = new System.Windows.Forms.DataGridView();
            this.buttonUserSeansList = new System.Windows.Forms.Button();
            this.buttonReserveTickets = new System.Windows.Forms.Button();
            this.numericUpDownUserTicketNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownUserSeansID = new System.Windows.Forms.NumericUpDown();
            this.labelUserSeansID = new System.Windows.Forms.Label();
            this.labelUserTicketNumber = new System.Windows.Forms.Label();
            this.buttonUserMyReservations = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonUserDeleteReseravtion = new System.Windows.Forms.Button();
            this.numericUpDownUserDeleteReseravtionNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserSeansList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUserTicketNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUserSeansID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUserDeleteReseravtionNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUserSeansList
            // 
            this.dataGridViewUserSeansList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserSeansList.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewUserSeansList.Name = "dataGridViewUserSeansList";
            this.dataGridViewUserSeansList.RowTemplate.Height = 25;
            this.dataGridViewUserSeansList.Size = new System.Drawing.Size(425, 363);
            this.dataGridViewUserSeansList.TabIndex = 0;
            // 
            // buttonUserSeansList
            // 
            this.buttonUserSeansList.Location = new System.Drawing.Point(126, 31);
            this.buttonUserSeansList.Name = "buttonUserSeansList";
            this.buttonUserSeansList.Size = new System.Drawing.Size(181, 23);
            this.buttonUserSeansList.TabIndex = 1;
            this.buttonUserSeansList.Text = "Pobierz Seanse";
            this.buttonUserSeansList.UseVisualStyleBackColor = true;
            this.buttonUserSeansList.Click += new System.EventHandler(this.buttonUserSeansList_Click);
            // 
            // buttonReserveTickets
            // 
            this.buttonReserveTickets.Location = new System.Drawing.Point(488, 197);
            this.buttonReserveTickets.Name = "buttonReserveTickets";
            this.buttonReserveTickets.Size = new System.Drawing.Size(167, 53);
            this.buttonReserveTickets.TabIndex = 2;
            this.buttonReserveTickets.Text = "Zarezerwuj Bilety";
            this.buttonReserveTickets.UseVisualStyleBackColor = true;
            this.buttonReserveTickets.Click += new System.EventHandler(this.buttonReserveTickets_Click);
            // 
            // numericUpDownUserTicketNumber
            // 
            this.numericUpDownUserTicketNumber.Location = new System.Drawing.Point(530, 151);
            this.numericUpDownUserTicketNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownUserTicketNumber.Name = "numericUpDownUserTicketNumber";
            this.numericUpDownUserTicketNumber.Size = new System.Drawing.Size(167, 23);
            this.numericUpDownUserTicketNumber.TabIndex = 3;
            this.numericUpDownUserTicketNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownUserSeansID
            // 
            this.numericUpDownUserSeansID.Location = new System.Drawing.Point(530, 113);
            this.numericUpDownUserSeansID.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownUserSeansID.Name = "numericUpDownUserSeansID";
            this.numericUpDownUserSeansID.Size = new System.Drawing.Size(167, 23);
            this.numericUpDownUserSeansID.TabIndex = 4;
            // 
            // labelUserSeansID
            // 
            this.labelUserSeansID.AutoSize = true;
            this.labelUserSeansID.Location = new System.Drawing.Point(440, 115);
            this.labelUserSeansID.Name = "labelUserSeansID";
            this.labelUserSeansID.Size = new System.Drawing.Size(84, 15);
            this.labelUserSeansID.TabIndex = 5;
            this.labelUserSeansID.Text = "Numer Seansu";
            // 
            // labelUserTicketNumber
            // 
            this.labelUserTicketNumber.AutoSize = true;
            this.labelUserTicketNumber.Location = new System.Drawing.Point(451, 153);
            this.labelUserTicketNumber.Name = "labelUserTicketNumber";
            this.labelUserTicketNumber.Size = new System.Drawing.Size(73, 15);
            this.labelUserTicketNumber.TabIndex = 6;
            this.labelUserTicketNumber.Text = "Ilośc Biletów";
            // 
            // buttonUserMyReservations
            // 
            this.buttonUserMyReservations.Location = new System.Drawing.Point(778, 31);
            this.buttonUserMyReservations.Name = "buttonUserMyReservations";
            this.buttonUserMyReservations.Size = new System.Drawing.Size(167, 23);
            this.buttonUserMyReservations.TabIndex = 7;
            this.buttonUserMyReservations.Text = "Moje Rezerwacje";
            this.buttonUserMyReservations.UseVisualStyleBackColor = true;
            this.buttonUserMyReservations.Click += new System.EventHandler(this.buttonUserMyReservations_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(744, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 309);
            this.dataGridView1.TabIndex = 8;
            // 
            // buttonUserDeleteReseravtion
            // 
            this.buttonUserDeleteReseravtion.Location = new System.Drawing.Point(770, 376);
            this.buttonUserDeleteReseravtion.Name = "buttonUserDeleteReseravtion";
            this.buttonUserDeleteReseravtion.Size = new System.Drawing.Size(142, 23);
            this.buttonUserDeleteReseravtion.TabIndex = 9;
            this.buttonUserDeleteReseravtion.Text = "Usuń Rezerwacje nr:";
            this.buttonUserDeleteReseravtion.UseVisualStyleBackColor = true;
            this.buttonUserDeleteReseravtion.Click += new System.EventHandler(this.buttonUserDeleteReseravtion_Click);
            // 
            // numericUpDownUserDeleteReseravtionNumber
            // 
            this.numericUpDownUserDeleteReseravtionNumber.Location = new System.Drawing.Point(918, 376);
            this.numericUpDownUserDeleteReseravtionNumber.Name = "numericUpDownUserDeleteReseravtionNumber";
            this.numericUpDownUserDeleteReseravtionNumber.Size = new System.Drawing.Size(66, 23);
            this.numericUpDownUserDeleteReseravtionNumber.TabIndex = 10;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 436);
            this.Controls.Add(this.numericUpDownUserDeleteReseravtionNumber);
            this.Controls.Add(this.buttonUserDeleteReseravtion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonUserMyReservations);
            this.Controls.Add(this.labelUserTicketNumber);
            this.Controls.Add(this.labelUserSeansID);
            this.Controls.Add(this.numericUpDownUserSeansID);
            this.Controls.Add(this.numericUpDownUserTicketNumber);
            this.Controls.Add(this.buttonReserveTickets);
            this.Controls.Add(this.buttonUserSeansList);
            this.Controls.Add(this.dataGridViewUserSeansList);
            this.Name = "User";
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserSeansList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUserTicketNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUserSeansID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUserDeleteReseravtionNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUserSeansList;
        private System.Windows.Forms.Button buttonUserSeansList;
        private System.Windows.Forms.Button buttonReserveTickets;
        private System.Windows.Forms.NumericUpDown numericUpDownUserTicketNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownUserSeansID;
        private System.Windows.Forms.Label labelUserSeansID;
        private System.Windows.Forms.Label labelUserTicketNumber;
        private System.Windows.Forms.Button buttonUserMyReservations;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUserDeleteReseravtion;
        private System.Windows.Forms.NumericUpDown numericUpDownUserDeleteReseravtionNumber;
    }
}