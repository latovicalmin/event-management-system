namespace eventManagement.WinUI.Users
{
    partial class frmUsers
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUsers);
            this.groupBox1.Location = new System.Drawing.Point(15, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korisnici";
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.FirstName,
            this.LastName,
            this.Username,
            this.Email,
            this.Active});
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(3, 16);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(593, 275);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvUsers_MouseDoubleClick);
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.Name = "UserId";
            this.UserId.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Ime";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Prezime";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Korisničko ime";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Status";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(536, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(6, 15);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(168, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Location = new System.Drawing.Point(15, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 41);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ime";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLastName);
            this.groupBox3.Location = new System.Drawing.Point(219, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 41);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prezime";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(6, 15);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(168, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 417);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Korisnici";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
    }
}