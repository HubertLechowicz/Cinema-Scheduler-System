
namespace WinFormsApp1
{
    partial class Admin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getUsersList = new System.Windows.Forms.Button();
            this.setNewWorkerEmail = new System.Windows.Forms.TextBox();
            this.buttonNewUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(528, 376);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // getUsersList
            // 
            this.getUsersList.Location = new System.Drawing.Point(183, 25);
            this.getUsersList.Name = "getUsersList";
            this.getUsersList.Size = new System.Drawing.Size(156, 38);
            this.getUsersList.TabIndex = 3;
            this.getUsersList.Text = "Pobierz liste userów";
            this.getUsersList.UseVisualStyleBackColor = true;
            this.getUsersList.Click += new System.EventHandler(this.getUsersList_Click);
            // 
            // setNewWorkerEmail
            // 
            this.setNewWorkerEmail.Location = new System.Drawing.Point(603, 172);
            this.setNewWorkerEmail.Name = "setNewWorkerEmail";
            this.setNewWorkerEmail.Size = new System.Drawing.Size(100, 23);
            this.setNewWorkerEmail.TabIndex = 4;
            // 
            // buttonNewUser
            // 
            this.buttonNewUser.Location = new System.Drawing.Point(580, 201);
            this.buttonNewUser.Name = "buttonNewUser";
            this.buttonNewUser.Size = new System.Drawing.Size(173, 23);
            this.buttonNewUser.TabIndex = 5;
            this.buttonNewUser.Text = "Stwórz nowego pracownika";
            this.buttonNewUser.UseVisualStyleBackColor = true;
            this.buttonNewUser.Click += new System.EventHandler(this.buttonNewUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email nowego pracownika";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNewUser);
            this.Controls.Add(this.setNewWorkerEmail);
            this.Controls.Add(this.getUsersList);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button getUsersList;
        private System.Windows.Forms.TextBox setNewWorkerEmail;
        private System.Windows.Forms.Button buttonNewUser;
        private System.Windows.Forms.Label label1;
    }
}