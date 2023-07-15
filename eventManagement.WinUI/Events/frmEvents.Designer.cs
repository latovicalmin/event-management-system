namespace eventManagement.WinUI.Events
{
    partial class frmEvents
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
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EventId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coatization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEvents);
            this.groupBox1.Location = new System.Drawing.Point(15, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korisnici";
            // 
            // dgvEvents
            // 
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventId,
            this.EventName,
            this.DateTime,
            this.Coatization,
            this.Duration,
            this.MaxPlaces,
            this.Active});
            this.dgvEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvents.Location = new System.Drawing.Point(3, 16);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvents.Size = new System.Drawing.Size(693, 275);
            this.dgvEvents.TabIndex = 0;
            this.dgvEvents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvEvents_MouseDoubleClick_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(636, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(6, 15);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(168, 20);
            this.txtEventName.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEventName);
            this.groupBox2.Location = new System.Drawing.Point(15, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 41);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Naslov";
            // 
            // EventId
            // 
            this.EventId.DataPropertyName = "EventId";
            this.EventId.HeaderText = "EventId";
            this.EventId.Name = "EventId";
            this.EventId.Visible = false;
            // 
            // Name
            // 
            this.EventName.DataPropertyName = "Name";
            this.EventName.HeaderText = "Naslov";
            this.EventName.Name = "Name";
            this.EventName.ReadOnly = true;
            // 
            // DateTime
            // 
            this.DateTime.DataPropertyName = "DateTime";
            this.DateTime.HeaderText = "Vrijeme";
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            // 
            // Coatization
            // 
            this.Coatization.DataPropertyName = "Coatization";
            this.Coatization.HeaderText = "Kotizacija";
            this.Coatization.Name = "Coatization";
            this.Coatization.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.HeaderText = "Trajanje (min)";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 150;
            // 
            // MaxPlaces
            // 
            this.MaxPlaces.DataPropertyName = "MaxPlaces";
            this.MaxPlaces.HeaderText = "Ukupno mjesta";
            this.MaxPlaces.Name = "MaxPlaces";
            this.MaxPlaces.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Status";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            // 
            // frmEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 417);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Događaji";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEvents_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coatization;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxPlaces;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
    }
}