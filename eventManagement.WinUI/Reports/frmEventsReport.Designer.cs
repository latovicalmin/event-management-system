namespace eventManagement.WinUI.Reports
{
    partial class frmEventsReport
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
            this.components = new System.ComponentModel.Container();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eventManagement.WinUI.Reports.EventsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 85);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(725, 474);
            this.reportViewer1.TabIndex = 0;
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(12, 31);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(200, 20);
            this.dateFrom.TabIndex = 1;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(277, 31);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 20);
            this.dateTo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(662, 28);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Pregled";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmEventsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 583);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmEventsReport";
            this.Text = "Izvještaj";
            this.Load += new System.EventHandler(this.frmEventsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShow;
    }
}