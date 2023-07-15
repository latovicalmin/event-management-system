namespace eventManagement.WinUI.Categories
{
    partial class frmCategories
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
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCategoryName);
            this.groupBox2.Location = new System.Drawing.Point(22, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 41);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Naziv";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(6, 15);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(135, 20);
            this.txtCategoryName.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(196, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEvents);
            this.groupBox1.Location = new System.Drawing.Point(22, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 294);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategorije";
            // 
            // dgvEvents
            // 
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryId,
            this.Name});
            this.dgvEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvents.Location = new System.Drawing.Point(3, 16);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvents.Size = new System.Drawing.Size(243, 275);
            this.dgvEvents.TabIndex = 0;
            this.dgvEvents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvEvents_MouseDoubleClick_1);
            // 
            // CategoryId
            // 
            this.CategoryId.DataPropertyName = "CategoryId";
            this.CategoryId.HeaderText = "CategoryId";
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.Visible = false;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Naziv";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 200;
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 419);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Text = "Kategorije";
            this.Load += new System.EventHandler(this.frmCategories_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
    }
}