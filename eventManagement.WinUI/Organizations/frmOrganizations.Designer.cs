namespace eventManagement.WinUI.Organizations
{
    partial class frmOrganizations
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOrganizationName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.OrganizationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logo = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOrganizationName);
            this.groupBox2.Location = new System.Drawing.Point(12, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 41);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Naslov";
            // 
            // txtOrganizationName
            // 
            this.txtOrganizationName.Location = new System.Drawing.Point(6, 15);
            this.txtOrganizationName.Name = "txtOrganizationName";
            this.txtOrganizationName.Size = new System.Drawing.Size(168, 20);
            this.txtOrganizationName.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(236, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEvents);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 294);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korisnici";
            // 
            // dgvEvents
            // 
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrganizationId,
            this.Name,
            this.Logo});
            this.dgvEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvents.Location = new System.Drawing.Point(3, 16);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvents.Size = new System.Drawing.Size(293, 275);
            this.dgvEvents.TabIndex = 0;
            this.dgvEvents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvEvents_MouseDoubleClick);
            // 
            // OrganizationId
            // 
            this.OrganizationId.DataPropertyName = "OrganizationId";
            this.OrganizationId.HeaderText = "OrganizationId";
            this.OrganizationId.Name = "OrganizationId";
            this.OrganizationId.Visible = false;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Naziv";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Logo
            // 
            this.Logo.DataPropertyName = "Logo";
            this.Logo.HeaderText = "Logo";
            this.Logo.Name = "Logo";
            this.Logo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Logo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Logo.Width = 150;
            // 
            // frmOrganizations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 448);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Text = "Organizacije";
            this.Load += new System.EventHandler(this.frmOrganizations_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOrganizationName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewImageColumn Logo;
    }
}