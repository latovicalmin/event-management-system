namespace eventManagement.WinUI.Events
{
    partial class frmSpeaker
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
            this.checkListSpeakers = new System.Windows.Forms.CheckedListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkListSpeakers
            // 
            this.checkListSpeakers.FormattingEnabled = true;
            this.checkListSpeakers.Location = new System.Drawing.Point(12, 24);
            this.checkListSpeakers.Name = "checkListSpeakers";
            this.checkListSpeakers.Size = new System.Drawing.Size(269, 274);
            this.checkListSpeakers.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(206, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSpeaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 361);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.checkListSpeakers);
            this.Name = "frmSpeaker";
            this.Text = "Predavači";
            this.Load += new System.EventHandler(this.frmSpeaker_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkListSpeakers;
        private System.Windows.Forms.Button btnSave;
    }
}